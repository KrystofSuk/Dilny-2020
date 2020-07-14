using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReviveLangi : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode Key;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(this.Key))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
