using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public string LevelName;

    public void Load(){
        Application.LoadLevel(LevelName);
    }
    
    public void Quit(){
        Application.Quit();
    }
}
