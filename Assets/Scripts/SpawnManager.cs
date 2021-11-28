using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    private Vector3 SpawnPos = new Vector3 (0, 0, 30);

    //Funci�n que determina posici�n y distancia de nuestro obst�culo
    public void SpawnObstacle()
    {
        float RandomY = Random.Range(-10f, 10f);
        SpawnPos = new Vector3(0, RandomY, SpawnPos.z + 50);
        Instantiate(ObstaclePrefab, SpawnPos, ObstaclePrefab.transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        //Hacer aparecer el obt�culo cada x tiempo 
        InvokeRepeating("SpawnObstacle", 0.5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
