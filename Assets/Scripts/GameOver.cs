using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    //public GameObject button;
    public Transform target;
    public Transform target2;
    public GameObject camera2;
    Player player;
    endGame end;
    Camera mainCamera;
    public void Start()
    {
        mainCamera = Camera.main;
        mainCamera.transform.SetParent(target);
    }
    public void GameOverF()
    {
        Debug.Log(GetComponent<Player>().player);
        if(GetComponent<Player>().player==true)
        {
            panel2.SetActive(true);
        }
        else
        {
            panel.SetActive(true);
        }
        camera2.SetActive(true);   
        mainCamera.transform.SetParent(target2);
    }
    public void Exit()
    {
        camera2.SetActive(false);
        panel2.SetActive(false);
        panel.SetActive(false);
        Application.Quit();
        Debug.Log("Fuera");
    }
}
