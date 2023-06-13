using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapaCrator : MonoBehaviour
{
    public GameObject WoodenFloor; // Prefab del suelo
    public GameObject stone2; // Prefab de las paredes
    public GameObject WoodenTable; // Prefab de las tablas
    public GameObject WoodenChair; //Prefab de las sillas
    public GameObject mesaPrinc0;
    public GameObject mesaPrinc1;
    public GameObject mesaPrinc2;
    public GameObject mesaPrinc3;
    public GameObject mesaPrinc4;
    public GameObject mesaPrinc5;
    public GameObject mesaPrinc6;
    public float tileSize = 1f; // Tamaño de cada cuadrícula en unidades de Unity
    public TextAsset mapaTexto; // El archivo de texto con la distribución del mapa
    public float offset = 0.25f;
    void Start()
    {
        string[] lineas = mapaTexto.text.Split('\n'); // Leer cada línea del archivo de texto
        int numRows = lineas.Length; // Obtener el número de filas del mapa
        int numCols = lineas[0].Length; // Obtener el número de columnas del mapa (asumiendo que todas las filas tienen la misma longitud)
        bool cont = true;
        bool cont2 = true;
        int contador = 0;
        for (int y = 0; y < numRows; y++)
        {
            for (int x = 0; x < numCols-1; x++)
            {
                char c = lineas[y][x]; // Obtener el carácter en la posición (x, y) del mapa

                // Calcular la posición en el mundo de Unity
                Vector3 position = new Vector3(x * tileSize + x * offset, -y * tileSize - y*offset, 0f);               
                Vector3 positioni = new Vector3(x * tileSize + x * offset, -y * tileSize - y * offset + 0.15f, -0.1f);
                Vector3 positionj = new Vector3(x * tileSize + x * offset, -y * tileSize - y * offset, -0.2f);
                if (y == 0)
                {
                    Vector3 positionp = new Vector3(x * tileSize + x * offset, -y * tileSize - y * offset + 0.5f, 0f);
                    Instantiate(stone2, positionp, Quaternion.identity); // Instanciar la pared en la posición correspondiente
                    if (x == 0)
                    {
                        Vector3 positionx = new Vector3(x * tileSize + x * offset - 0.5f, -y * tileSize - y * offset + 0.5f, 0f);
                        Instantiate(stone2, positionx, Quaternion.identity); // Instanciar la pared en la posición correspondiente
                    }
                    if ((x == numCols-2)&&(cont==true))
                    {                        
                        Vector3 positiony = new Vector3(x * tileSize + x * offset + 0.5f, -y * tileSize - y * offset + 0.5f, 0f);
                        Instantiate(stone2, positiony, Quaternion.identity); // Instanciar la pared en la posición correspondiente
                        cont = false;
                    }
                }
                if (x == 0)
                {
                    Vector3 positionp = new Vector3(x * tileSize + x * offset -0.5f, -y * tileSize - y * offset, 0f);
                    Instantiate(stone2, positionp, Quaternion.identity); // Instanciar la pared en la posición correspondiente
                }
                if (y == numRows-1)
                {
                    Vector3 positionp = new Vector3(x * tileSize + x * offset, -y * tileSize - y * offset - 0.5f, 0f);
                    Instantiate(stone2, positionp, Quaternion.identity); // Instanciar la pared en la posición correspondiente
                    if (x == 0)
                    {
                        Vector3 positionx = new Vector3(x * tileSize + x * offset - 0.5f, -y * tileSize - y * offset - 0.5f, 0f);
                        Instantiate(stone2, positionx, Quaternion.identity); // Instanciar la pared en la posición correspondiente
                    }
                    if ((x == numCols - 2) && (cont2 == true))
                    {
                        Vector3 positiony = new Vector3(x * tileSize + x * offset + 0.5f, -y * tileSize - y * offset - 0.5f, 0f);
                        Instantiate(stone2, positiony, Quaternion.identity); // Instanciar la pared en la posición correspondiente
                        cont2 = false;
                    }
                }
                if (x == numCols-2)
                {
                    Vector3 positionp = new Vector3(x * tileSize + x * offset + 0.5f, -y * tileSize - y * offset, 0f);
                    Instantiate(stone2, positionp, Quaternion.identity); // Instanciar la pared en la posición correspondiente
                }
                Instantiate(WoodenFloor, position, Quaternion.identity); // Instanciar el suelo en la posición correspondiente
                /*if (c == '-')
                {
                    Instantiate(WoodenFloor, position, Quaternion.identity); // Instanciar el suelo en la posición correspondiente
                }*/
                if (c == 'T')
                {
                    Instantiate(WoodenTable, positionj, Quaternion.identity); // Instanciar la tabla en la posición correspondiente
                    Instantiate(WoodenChair, positioni, Quaternion.identity); // Instanciar la silla en la posición correspondiente
                }
                if (c == 'm')
                {
                    if (contador == 0)
                    {
                        Instantiate(mesaPrinc0, positionj, Quaternion.identity); // Instanciar la tabla en la posición correspondiente
                        contador++;
                    }
                    else if (contador == 1)
                    {
                        Instantiate(mesaPrinc1, positionj, Quaternion.identity); // Instanciar la tabla en la posición correspondiente
                        contador++;
                    }
                    else if (contador == 2)
                    {                    
                        contador++;
                    }
                    else if (contador == 3)
                    {
                        Instantiate(mesaPrinc2, positionj, Quaternion.identity); // Instanciar la tabla en la posición correspondiente
                        contador++;
                    }
                    else if (contador == 4)
                    {
                        Instantiate(mesaPrinc3, positionj, Quaternion.identity); // Instanciar la tabla en la posición correspondiente
                        contador++;
                    }
                    else if (contador == 5)
                    {
                        Instantiate(mesaPrinc4, positionj, Quaternion.identity); // Instanciar la tabla en la posición correspondiente
                        contador++;
                    }
                    else if (contador == 6)
                    {
                        Instantiate(mesaPrinc5, positionj, Quaternion.identity); // Instanciar la tabla en la posición correspondiente
                        contador++;
                    }
                    else if (contador == 7)
                    {
                        Instantiate(mesaPrinc6, positionj, Quaternion.identity); // Instanciar la tabla en la posición correspondiente
                        contador++;
                    }
                }
            }
        }
    }
}
