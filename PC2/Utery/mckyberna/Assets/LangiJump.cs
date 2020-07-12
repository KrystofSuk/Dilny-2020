using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LangiJump : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode Key;
    public Rigidbody Car;
    public float Force = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKeyDown(this.Key))
            return;

        this.Car.AddForce(Vector3.up * Force, ForceMode.VelocityChange);
    }
}
