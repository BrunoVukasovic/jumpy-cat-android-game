using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSpawner : MonoBehaviour
{

    public float maxYpos;
    public float SpawnTime;
    public GameObject wood;
    // Start is called before the first frame update
    void Start()
    {
        StartSpawningWoods();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSpawningWoods()
    {
        InvokeRepeating("SpawnWood", 0.2f, SpawnTime);
    }

    void SpawnWood()
    {
        Instantiate(wood, new Vector3(transform.position.x, Random.Range(-maxYpos, maxYpos), 0), Quaternion.identity);

    }

    public void StopSpawningWoods()
    {
        CancelInvoke("SpawnWood");
    }
}
