using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    private Vector3 SpawnPos = (0, 0, 30);

    public void SpawnObstacle()
    {
        float RandomY = Random.Range(-10f, 10f);
        return new Vector3(0, RandomY, SpawnPos.z + 50);
        Instantiate(ObstaclePrefab, SpawnPos, ObstaclePrefab.transform.rotation);
    }

    private Vector3 RandomY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
