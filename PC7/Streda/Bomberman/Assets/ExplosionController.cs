using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Contains("Player")) Destroy(col.gameObject);

        if (col.gameObject.CompareTag("Ground"))
        {
            Debug.Log(gameObject.name + " collided with " + col.name);
            Destroy(this.gameObject);
            if ((col.gameObject.GetComponent("Box") as Box) != null) Destroy(col.gameObject);
        }
    }
}
