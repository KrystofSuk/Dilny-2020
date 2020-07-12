using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class McAdditionScript : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoints(float value)
    {
        var label = this.GetComponent<Text>();

        float score = 0;
        float.TryParse(label.text, out score);

        score += value;
        label.text = $"{score.ToString("0.00")}";
    }
}
