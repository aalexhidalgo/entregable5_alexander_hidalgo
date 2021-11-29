using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    private Vector3 SpawnPos = new Vector3 (0, 0, 30);
    private int YRange = 10;

    //Función que determina en que posición se generará el obstáculo
    public void SpawnObstacle()
    {
        float RandomY = Random.Range(-YRange, YRange);
        SpawnPos = new Vector3(0, RandomY, SpawnPos.z + 50);
        Instantiate(ObstaclePrefab, SpawnPos, ObstaclePrefab.transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Llamamos a la función una primera vez y establecemos cada cuanto queremos que la vuelva a llamar
        InvokeRepeating("SpawnObstacle", 0.5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
