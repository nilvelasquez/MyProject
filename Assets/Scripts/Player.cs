using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject exit;
    public bool player=false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Exit")
        {
            this.player = true;
        }
        GetComponent<GameOver>().GameOverF();   
    }
}
