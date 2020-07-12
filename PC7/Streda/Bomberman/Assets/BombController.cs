using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public float timeToExplosion = 2;
    public float blastSize = 2;//*1,3 Koeficient abych z 0,75 udělal 1
    public float blastSpeed = 1;

    private bool exploding = false;

    private GameObject up;
    private GameObject down;
    private GameObject left;
    private GameObject right;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Explode", timeToExplosion);
        up = transform.GetChild(0).gameObject;
        down = transform.GetChild(1).gameObject;
        left = transform.GetChild(2).gameObject;
        right = transform.GetChild(3).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount == 0) Destroy(this.gameObject);
    }

    void Explode()
    {
        up.SetActive(true);
        down.SetActive(true);
        left.SetActive(true);
        right.SetActive(true);

        exploding = true;
        //horizontalCollider.size = new Vector2(blastSize * 1.3f, 1);
        //verticalCollider.size = new Vector2(1, blastSize * 1.3f);
        Shoot(new Vector2(0, 1), up);
        Shoot(new Vector2(0, -1), down);
        Shoot(new Vector2(-1, 0), left);
        Shoot(new Vector2(1, 0), right);
        
    }

    void Shoot(Vector2 shootDirection, GameObject bullet)
    {
        Vector2 actualBulletDirection = shootDirection;

        bullet.transform.eulerAngles = new Vector3(0f, 0f, Utils.Angle(actualBulletDirection));

        // push the created objects, but only if they have a Rigidbody2D
        Rigidbody2D rigidbody2D = bullet.GetComponent<Rigidbody2D>();
        if (rigidbody2D != null)
        {
            rigidbody2D.AddForce(actualBulletDirection * blastSpeed, ForceMode2D.Impulse);
        }
    }
}
