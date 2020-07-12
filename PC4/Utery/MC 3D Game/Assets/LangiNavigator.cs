using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LangiNavigator : MonoBehaviour
{
    // Start is called before the first frame u
    public bool LockY = true;
    private GameObject[] finishObjects;

    public McFood Food;
    private bool toFood = true;

    void Start()
    {
        this.finishObjects = GameObject.FindGameObjectsWithTag("Finish");

        Food.FoodSet.AddListener(() => toFood = false);
        Food.FoodRemoved.AddListener(() => toFood = true);
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Vector3.zero;
        var minDist = float.MaxValue;

        if (toFood)
        {
            foreach (var pickup in GameObject.FindGameObjectsWithTag("Pickup"))
            {
                var distvec = this.gameObject.transform.position - pickup.transform.position;
                if (distvec.magnitude < minDist)
                    dir = distvec.normalized;
            }
        }
        else
        {
            foreach (var finishobject in finishObjects)
            {
                var distvec = this.gameObject.transform.position - finishobject.transform.position;
                if (distvec.magnitude < minDist)
                    dir = distvec.normalized;
            }
        }



        if (this.LockY)
        {
            dir.y = 0;
            dir.Normalize();
        }


        this.transform.rotation = Quaternion.LookRotation(-dir);
    }
}
