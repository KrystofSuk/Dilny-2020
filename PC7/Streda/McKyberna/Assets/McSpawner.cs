using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class McSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Food;
    public List<GameObject> Positions;
    public float Timeout = 10;

    private float timeLeft;
    private Dictionary<float, GameObject> spawned;
    void Start()
    {
        this.timeLeft = this.Timeout;
        this.spawned = new Dictionary<float, GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        this.timeLeft -= Time.deltaTime;

        if (this.timeLeft <= 0)
        {
            this.timeLeft = this.Timeout;

            var toCheck = new List<GameObject>(this.Positions);
            int index = Random.Range(0, toCheck.Count);  

            Debug.Log("Spawning!!!");

            while (toCheck.Count > 0)
            {
                if (spawned.ContainsKey(index) && spawned[index] != null)
                {
                    toCheck.RemoveAt(index);
                    index = Random.Range(0, toCheck.Count);
                    continue;
                }


                var clone = GameObject.Instantiate(this.Food);
                clone.transform.position = this.Positions[index].transform.position;

                if (!spawned.ContainsKey(index))
                    spawned.Add(index, clone);
                else
                    spawned[index] = clone;

                break;
            }
        }
    }
}
