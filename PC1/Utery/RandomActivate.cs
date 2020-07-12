using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomActivate : MonoBehaviour
{
    public List<GameObject> gameObjects;

    bool _inUse = false;

    // Start is called before the first frame update
    void Start()
    {
        Randomize();
    }

    public void Randomize()
    {
        StartCoroutine(RandomizeEnumerator());
    }

    IEnumerator RandomizeEnumerator()
    {
        yield return new WaitForSeconds(0.1f);
        if (!_inUse)
        {
            _inUse = true;

            foreach (var item in gameObjects)
            {
                item.SetActive(false);
            }
            gameObjects[Random.Range(0, gameObjects.Count)].SetActive(true);

            _inUse = false;
        }
    }
}
