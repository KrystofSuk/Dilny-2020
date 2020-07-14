using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/McFood", order = 1)]
public class McFood : ScriptableObject
{
    [HideInInspector]
    public UnityEvent FoodSet = new UnityEvent();

    [HideInInspector]
    public UnityEvent FoodRemoved = new UnityEvent();

    public float Value = 1;
     
    private bool food;


    public bool HasFood() => this.food;

    public void SetFood()
    {
        this.food = true;
        this.FoodSet.Invoke();
    }
    public void RemoveFood()
    {
        this.food = false;
        this.FoodRemoved.Invoke();
    }
}
