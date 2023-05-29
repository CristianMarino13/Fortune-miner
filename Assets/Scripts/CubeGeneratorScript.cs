using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGeneratorScript : MonoBehaviour
{
    public GameObject cubePrefab;  // Prefab del cubo
    public int numberOfCubes; 
    public int distancex;
    public int distancey;
    public int distancez;


    private void Start()
    {
        GenerateCubes();
    }

    private void GenerateCubes()
    {
        for (int i = 0; i < numberOfCubes; i++)
        {
            // Genera una posición aleatoria en el rango de -10 a 10 para x, y, z
            Vector3 randomPosition = new Vector3(Random.Range(-distancex,distancex), Random.Range(0f, distancey), Random.Range(100f, distancez));

            // Instancia un nuevo cubo en la posición aleatoria
            GameObject cube = Instantiate(cubePrefab, randomPosition, Quaternion.identity);
        }
    }
}
