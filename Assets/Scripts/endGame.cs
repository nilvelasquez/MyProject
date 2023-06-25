using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {     
        Debug.Log("Ex");
        Application.Quit();    
    }
}
