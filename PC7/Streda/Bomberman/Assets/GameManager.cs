using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public GameObject Player4;

    public GameObject endMenu;
    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player1 == null && Player2 == null && Player3 == null) { winText.text = "Player 4 won!"; endMenu.SetActive(true); Time.timeScale = 0f; }

        if (Player1 == null && Player2 == null && Player4 == null) { winText.text = "Player 3 won!"; endMenu.SetActive(true); Time.timeScale = 0f; }
        
        if (Player1 == null && Player3 == null && Player4 == null) { winText.text = "Player 2 won!"; endMenu.SetActive(true); Time.timeScale = 0f; }
        
        if (Player2 == null && Player3 == null && Player4 == null) { winText.text = "Player 1 won!"; endMenu.SetActive(true); Time.timeScale = 0f; }

        if (Input.GetKey(KeyCode.R))
        {
            ReloadLevel();
        }
    }

    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }

    public void ReloadLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name).completed += (s) =>
        {
            Time.timeScale = 1f;
        };
        
    }
}
