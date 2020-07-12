using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurboScript : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode Key;
    public Rigidbody Car;
    public float Strength = 6f;

    public Camera Camera;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (this.Camera != null)
        {
            this.Camera.fieldOfView = Mathf.Clamp(60.0f + this.Car.velocity.magnitude, 45f, 90f);
        }

        if (Input.GetKey(this.Key))
        {
            this.Car.AddForce(this.Car.gameObject.transform.forward * this.Strength, ForceMode.VelocityChange);
        }
    }
}
