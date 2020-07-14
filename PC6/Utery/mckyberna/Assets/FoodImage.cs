using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FoodImage : MonoBehaviour
{
    // Start is called before the first frame update
    public McFood Food;

    void Start()
    {
        var image = this.gameObject.GetComponent<Image>();
        image.enabled = false;

        

        this.Food.FoodSet.AddListener(() =>
        {
            image.enabled = true;
        });

        this.Food.FoodRemoved.AddListener(() =>
        {
            image.enabled = false;
        });

    }

    // Update is called once per frame
    void Update()
    {

    }
}
