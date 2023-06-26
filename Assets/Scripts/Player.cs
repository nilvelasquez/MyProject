using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    GameOver game;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        game.GameOverF();
        //Application.Quit();        
    }
}
