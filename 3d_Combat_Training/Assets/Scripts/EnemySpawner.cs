using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Vector3 spawnLocation;
    public GameObject spawnType;
    public float yLocation;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = new Vector3(transform.position.x, yLocation, transform.position.z);
        SpawnObject();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObject()
    {
        Instantiate(spawnType, spawnLocation, Quaternion.identity);
    }

}