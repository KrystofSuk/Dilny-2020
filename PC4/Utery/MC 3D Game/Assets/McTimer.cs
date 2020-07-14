using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class McTimer : MonoBehaviour
{
    // Start is called before the first frame update
    public float Timeout = 10;
    public Text TimeLabel;
    public Text HealthLabel;

    public int Health = 1;
    public string EndScene = "end";


    private bool running;
    private float timeLeft;


    private List<McFood> food = new List<McFood>();
    void Start()
    {
        this.HealthLabel.text = $"{this.Health} hp";
        this.timeLeft = this.Timeout;
    }

    void UpdateLabel()
    {
        if (this.TimeLabel != null)
            this.TimeLabel.text = $"{this.timeLeft.ToString("0.00")}s";
    }

    // Update is called once per frame
    void Update()
    {
        if (this.running == false)
            return;

        this.timeLeft -= Time.deltaTime;

        if (this.timeLeft <= 0)
        {
            this.Health -= 1;
            this.HealthLabel.text = $"{this.Health} hp";
            if (this.Health <= 0)
            {
                SceneManager.LoadScene(this.EndScene);
            }

            this.StopTimer();
            return;
        }

        this.UpdateLabel();
    }

    public void StopTimer()
    {
        this.timeLeft = 0;

        foreach (var food in this.food)
            food.RemoveFood();

        food.Clear();
        this.running = false;

        this.UpdateLabel();
    }

    public void StartTimer(McFood food)
    {
        this.food.Add(food);

        if (this.Timeout < 0) return;

        this.timeLeft = this.Timeout;
        this.running = true;
    }
}
