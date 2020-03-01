using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public static bool isPlayerDead = false;
    private Text gameOver;

    //if its the begining of game, gameover text is not visible
    void Start()
    {
        gameOver = GetComponent<Text>();
        gameOver.enabled = false;
    }

    //if player is dead, pause game and make gameover true
    void Update()
    {
        if (isPlayerDead)
        {
            Time.timeScale = 0;
            gameOver.enabled = true;
        }
    }
}
