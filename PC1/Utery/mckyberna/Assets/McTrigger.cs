using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class McTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent TouchAction;

    //public McTimer Timer;
    public McFood Food;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider c)
    {
        this.TouchAction?.Invoke();

        GameObject.FindGameObjectWithTag("Player").GetComponent<McTimer>().StartTimer(this.Food);
        //this.Timer.StartTimer(this.Food);
        this.Food.SetFood();
    }
}
