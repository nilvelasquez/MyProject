using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public void exitfinal()
    {
        GetComponent<GameOver>().GameOverF();
    }
}
