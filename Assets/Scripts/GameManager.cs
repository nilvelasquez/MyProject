using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private mapaCreator mapaScript;
    private EnemySpawn enemy;
    //private int level = 3;

    // Start is called before the first frame update
    
    void Awake()
    {
        mapaScript = GetComponent<mapaCreator>();
        InitGame();
    }
    void InitGame()
    {
        mapaScript.Start();
        //enemy.SpawnEnemy();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
