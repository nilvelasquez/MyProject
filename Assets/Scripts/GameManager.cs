using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private mapaCreator mapaScript;
    public GameObject enemy1;
    public GameObject player;
    public float tileSize = 1f;
    public float offset = 0.25f;
    bool comp = false;
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
        for (int i = 0; i < 1; i++)
        { 
            float y = UnityEngine.Random.Range(1, 4);
            float x = UnityEngine.Random.Range(1, 4);
            Vector3 position = new Vector3(x * tileSize, -y * tileSize, -3f);
            for (int j=0; j < mapaScript.mesas.Length ; j++)
            {
                if (position == mapaScript.mesas[j])
                {
                    comp = true;
                }
                if (comp == true)
                {
                    break;
                }
            }
            if (comp == true)
            {
                float z = UnityEngine.Random.Range(1, 4);
                float m = UnityEngine.Random.Range(1, 4);
                Vector3 positioni = new Vector3(m * tileSize, -z * tileSize, -3f);
                Instantiate(enemy1, positioni, Quaternion.identity);
                //enemy1.GetComponent<Enemy>().SetTarget(player); 
            }
            else
            {
                Instantiate(enemy1, position, Quaternion.identity);
                //enemy1.GetComponent<Enemy>().SetTarget(player);
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
