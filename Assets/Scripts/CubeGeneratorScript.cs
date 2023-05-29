using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGeneratorScript : MonoBehaviour
{
    public List<GameObject> cubePrefabs;  // Prefab del cubo
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
           
            Vector3 randomPosition = new Vector3(Random.Range(-distancex,distancex), Random.Range(0f, distancey), Random.Range(100f, distancez));
            GameObject cubePrefab = cubePrefabs[Random.Range(0, cubePrefabs.Count)];
            GameObject cube = Instantiate(cubePrefab, randomPosition, Quaternion.identity);
            cube.GetComponent<Renderer>().material.color = Random.ColorHSV();
        }
    }
}
