using UnityEngine;
using System.Collections;

[AddComponentMenu("Playground/Movement/Move With Arrows")]
[RequireComponent(typeof(Rigidbody2D))]
public class Move : Physics2DObject
{
	[Header("Input keys")]
	public Enums.KeyGroups typeOfControl = Enums.KeyGroups.ArrowKeys;

	[Header("Movement")]
	[Tooltip("Speed of movement")]
	public float speed = 5f;

	// The direction that will face the player
	public Enums.Directions lookAxis = Enums.Directions.Up;

	private Vector2 movement, cachedDirection;
	private float moveHorizontal;
	private float moveVertical;


	// Update gets called every frame
	void Update ()
	{	
		// Moving with the arrow keys
        switch(typeOfControl)
        {
            case Enums.KeyGroups.ArrowKeys:
                moveHorizontal = Input.GetAxis("Horizontal");
                moveVertical = Input.GetAxis("Vertical");
                break;
            case Enums.KeyGroups.WASD:
                moveHorizontal = Input.GetAxis("Horizontal2");
                moveVertical = Input.GetAxis("Vertical2");
                break;
            case Enums.KeyGroups.IJKL:
                moveHorizontal = Input.GetAxis("Horizontal3");
                moveVertical = Input.GetAxis("Vertical3");
                break;
            case Enums.KeyGroups.EightFourFiveSix:
                moveHorizontal = Input.GetAxis("Horizontal4");
                moveVertical = Input.GetAxis("Vertical4");
                break;
        }

        movement = new Vector2(moveHorizontal, moveVertical);
	}

	// FixedUpdate is called every frame when the physics are calculated
	void FixedUpdate ()
	{
		// Apply the force to the Rigidbody2d
		rigidbody2D.AddForce(movement * speed * 10f);
	}
}