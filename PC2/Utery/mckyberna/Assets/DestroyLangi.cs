using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyLangi : MonoBehaviour
{
    // Start is called before the first frame update

    public string EndScene;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        var langi = GameObject.FindGameObjectWithTag("Player");

        if (this.EndScene != null)
            SceneManager.LoadScene(this.EndScene);

        if (langi != null)
            Destroy(langi);
    }
}
