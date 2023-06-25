using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private mapaCreator mapaScript;
    private EnemySpawn enemy;
    public GameObject enemy1;
    public GameObject player;
    public float tileSize = 1f;
    public float offset = 0.25f;
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
        for (int i = 0; i < 3; i++)
        { 
            float y = UnityEngine.Random.Range(1, 4);
            float x = UnityEngine.Random.Range(1, 4);
            Vector3 position = new Vector3(x * tileSize, -y * tileSize, -3f);
            Instantiate(enemy1, position, Quaternion.identity);
            //enemy1.GetComponent<Enemy>().SetTarget(player);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
