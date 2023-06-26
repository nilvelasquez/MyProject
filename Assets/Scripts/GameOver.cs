using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject panel;
    public void GameOverF()
    {        
        Debug.Log("Game Over");
        panel.SetActive(true);
    }
}
