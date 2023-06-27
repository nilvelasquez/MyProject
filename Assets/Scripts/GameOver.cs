using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject panel;
    public GameObject button;
    public void GameOverF()
    {
        //panel = GameObject.FindWithTag("Panel");
        Debug.Log("Game Over "+ panel);
        button.SetActive(true);
        panel.SetActive(true);
    }
    public void Exit()
    {
        panel.SetActive(false);
        button.SetActive(false);
        Application.Quit();
        Debug.Log("Fuera");
    }
}
