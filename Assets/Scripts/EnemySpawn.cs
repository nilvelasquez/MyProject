using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    /*public GameObject enemy1;
    public GameObject player;
    public float tileSize = 1f;
    public float offset = 0.25f;
    mapaCreator maps;
    // Update is called once per frame    
    public void SpawnEnemy()
    {       
        float y = UnityEngine.Random.Range(1, 4);
        float x = UnityEngine.Random.Range(1, 4);
        Vector3 position = new Vector3(2*tileSize + x*offset, -2*tileSize -y*offset, -3f); ;
        Instantiate(enemy1, position, Quaternion.identity);
        enemy1.GetComponent<Enemy>().SetTarget(player);
        Debug.Log("asdas"+player);
    }

    //Función para determinar la posición donde apareceran los enemigos de forma aleatoria y siempre fuera de la pantalla
    private Vector3 RandomPosition()
    {
        Vector3 position = new Vector3();
        float y = UnityEngine.Random.Range(0, maps.GetCols() - 1);
        float x = UnityEngine.Random.Range(0, maps.GetRows() - 1);
        position = new Vector3(5f, 5f, 3f);
        return position;
    }*/
}
