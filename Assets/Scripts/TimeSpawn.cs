using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay; 

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpaenObject".spawnTime,spawnDelay);
    }
    public void SpawnObject();
    {
        Instantiate(spawnee,teansform.position,transform.rotation);
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
            

        }
    
        
    }