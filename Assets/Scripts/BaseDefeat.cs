using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BaseDefeat : MonoBehaviour
{
    private Transform playerBase;

    // Initialize playerBase by getting its transform
    void Start()
    {
        playerBase = GetComponent<Transform>();
    }

    //if base count = 0, set gameover to true, ending game
    void Update()
    {
        if (playerBase.childCount == 0)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
    }
}
