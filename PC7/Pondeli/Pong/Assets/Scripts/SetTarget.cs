using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTarget : MonoBehaviour
{
    public string ParentSetter;

    void Start()
    {
        Target();
    }


    public void Target()
    {
        GameObject.Find(ParentSetter).GetComponent<FollowTarget>().target = transform;
    }
}
