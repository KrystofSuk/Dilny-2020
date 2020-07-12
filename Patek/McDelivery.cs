using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class McDelivery : MonoBehaviour
{
    // Start is called before the first frame update
    public List<McFood> Food = new List<McFood>();
    public Text ScoreLabel;

    public float Win = 100f;
    public string Scene;
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



        float score = 0;
        float.TryParse(this.ScoreLabel.text, out score);

        score += add;
        this.ScoreLabel.text = $"{score.ToString("0.00")}";

        if (this.Scene != null && score >= this.Win)
            SceneManager.LoadScene(this.Scene);

        GameObject.FindGameObjectWithTag("Player")?.GetComponent<McTimer>()?.StopTimer();
    }
}
