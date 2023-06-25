using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Random = UnityEngine.Random;

public class mapaCreator : MonoBehaviour
{
    public GameObject WoodenFloor; // Prefab del suelo
    public GameObject stone2; // Prefab de las paredes
    public GameObject WoodenTable; // Prefab de las tablas
    public GameObject WoodenChair; //Prefab de las sillas
    public GameObject player;
    public GameObject enemy1;
    Transform attackPosition;
    public GameObject Exit; //Prefab del exit    
    public float tileSize = 1f; // Tama�o de cada cuadr�cula en unidades de Unity
    public TextAsset mapaTexto; // El archivo de texto con la distribuci�n del mapa
    public float offset = 0.25f;
    public Vector3 exit;
    public int numRows;
    public int numCols;
    public void Start()
    {
        string[] lineas = mapaTexto.text.Split('\n'); // Leer cada l�nea del archivo de texto
        this.numRows = lineas.Length; // Obtener el n�mero de filas del mapa
        this.numCols = lineas[0].Length; // Obtener el n�mero de columnas del mapa (asumiendo que todas las filas tienen la misma longitud)
        SetCols(numCols);
        SetRows(numRows);
        bool cont = true;
        bool cont2 = true;
        for (int y = 0; y < numRows; y++)
        {
            for (int x = 0; x < numCols-1; x++)
            {
                char c = lineas[y][x]; // Obtener el car�cter en la posici�n (x, y) del mapa

                // Calcular la posici�n en el mundo de Unity
                Vector3 position = new Vector3(x * tileSize + x * offset, -y * tileSize - y*offset, 0f);               
                Vector3 positioni = new Vector3(x * tileSize + x * offset, -y * tileSize - y * offset + 0.15f, -0.1f);
                Vector3 positionj = new Vector3(x * tileSize + x * offset, -y * tileSize - y * offset, -0.2f);
                if (y == 0)
                {
                    Vector3 positionp = new Vector3(x * tileSize + x * offset, -y * tileSize - y * offset + 0.5f, 0f);
                    Instantiate(stone2, positionp, Quaternion.identity); // Instanciar la pared en la posici�n correspondiente
                    if (x == 0)
                    {
                        Vector3 positionx = new Vector3(x * tileSize + x * offset - 0.5f, -y * tileSize - y * offset + 0.5f, 0f);
                        Instantiate(stone2, positionx, Quaternion.identity); // Instanciar la pared en la posici�n correspondiente
                        //Instantiate(player, position, Quaternion.identity); // Instanciar el player en la posici�n correspondiente
                    }
                    if ((x == numCols-2)&&(cont==true))
                    {                        
                        Vector3 positiony = new Vector3(x * tileSize + x * offset + 0.5f, -y * tileSize - y * offset + 0.5f, 0f);
                        Instantiate(stone2, positiony, Quaternion.identity); // Instanciar la pared en la posici�n correspondiente
                        cont = false;
                    }
                }
                if (x == 0)
                {
                    Vector3 positionp = new Vector3(x * tileSize + x * offset - 0.5f, -y * tileSize - y * offset, 0f);
                    Instantiate(stone2, positionp, Quaternion.identity); // Instanciar la pared en la posici�n correspondiente
                }
                if (y == numRows-1)
                {
                    Vector3 positionp = new Vector3(x * tileSize + x * offset, -y * tileSize - y * offset - 0.5f, 0f);
                    Instantiate(stone2, positionp, Quaternion.identity); // Instanciar la pared en la posici�n correspondiente
                    if (x == 0)
                    {
                        Vector3 positionx = new Vector3(x * tileSize + x * offset - 0.5f, -y * tileSize - y * offset - 0.5f, 0f);
                        Instantiate(stone2, positionx, Quaternion.identity); // Instanciar la pared en la posici�n correspondiente
                    }
                    if ((x == numCols - 2) && (cont2 == true))
                    {
                        Vector3 positiony = new Vector3(x * tileSize + x * offset + 0.5f, -y * tileSize - y * offset - 0.5f, 0f);
                        Vector3 positionx = new Vector3(x * tileSize + x * offset - 0.5f, -y * tileSize - y * offset - 0.5f, -3f);
                        Instantiate(stone2, positiony, Quaternion.identity); // Instanciar la pared en la posici�n correspondiente
                        exit = positionx;
                        Instantiate(Exit, positionx, Quaternion.identity);
                        cont2 = false;
                    }
                }
                if (x == numCols-2)
                {
                    Vector3 positionp = new Vector3(x * tileSize + x * offset + 0.5f, -y * tileSize - y * offset, 0f);
                    Instantiate(stone2, positionp, Quaternion.identity); // Instanciar la pared en la posici�n correspondiente
                }
                Instantiate(WoodenFloor, position, Quaternion.identity); // Instanciar el suelo en la posici�n correspondiente
                /*if (c == '-')
                {
                    Instantiate(WoodenFloor, position, Quaternion.identity); // Instanciar el suelo en la posici�n correspondiente
                }*/
                if (c == 'T')
                {
                    Instantiate(WoodenTable, positionj, Quaternion.identity); // Instanciar la tabla en la posici�n correspondiente
                    Instantiate(WoodenChair, positioni, Quaternion.identity); // Instanciar la silla en la posici�n correspondiente
                }
            }
        }       
    }
    public void SetCols(int numCols)
    {
        this.numCols = numCols;
    }
    public void SetRows(int numRows)
    {
        this.numRows = numRows;
    }
    public int GetCols()
    {
        return this.numCols;
    }
    public int GetRows()
    {
        return this.numRows;
    }
}
