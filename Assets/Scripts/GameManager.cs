using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public mapaCreator mapaScript;
    private int level = 3;

    // Start is called before the first frame update
    
    void Awake()
    {
        mapaScript = GetComponent<mapaCreator>();
        InitGame();
    }
    void InitGame()
    {
        mapaScript.Start();
        mapaScript.SetUpScene(level);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
