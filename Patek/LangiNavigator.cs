using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LangiNavigator : MonoBehaviour
{
    // Start is called before the first frame u
    public bool LockY = true;
    private GameObject[] finishObjects;

    void Start()
    {
        this.finishObjects = GameObject.FindGameObjectsWithTag("Finish");
    }

    // Update is called once per frame
    void Update()
    {
        var dir = Vector3.zero;
        var minDist = float.MaxValue;

        foreach (var finishObject in finishObjects)
        {
            var distvec = this.gameObject.transform.position - finishObject.transform.position;
            if (distvec.magnitude < minDist)
                dir = distvec.normalized;
        }

        if (this.LockY)
        {
            dir.y = 0;
            dir.Normalize();
        }


        this.transform.rotation = Quaternion.LookRotation(-dir);
    }
}
