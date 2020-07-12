using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class McDelivery : MonoBehaviour
{
    // Start is called before the first frame update
    public List<McFood> Food = new List<McFood>();
    public Text ScoreLabel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        float add = 0;
        foreach (var f in this.Food)
        {
            if (!f.HasFood()) continue;

            //Destroy(f);

            f.RemoveFood();
            add += f.Value;
        }



        int score = 0;
        int.TryParse(this.ScoreLabel.text, out score);

        this.ScoreLabel.text = $"{score + add}";

        GameObject.FindGameObjectWithTag("Player")?.GetComponent<McTimer>()?.StopTimer();
    }
}
