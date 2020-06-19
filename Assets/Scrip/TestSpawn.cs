using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawn : MonoBehaviour
{
    [SerializeField] GameObject Enemy,SpawnPosition;
    public float XPosition, ZPosition;
    static public float EnemyCount = 0;
  void Start()
    {
        
    }
    void Update()
    {
    
    }
    IEnumerator SpawnDelay()
    {
        Spawn();
        yield return new WaitForSeconds(1f);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "MainCharecter")
        {
            if (EnemyCount < 10)
            {
                StartCoroutine(SpawnDelay());
            }
        }
    }
    void Spawn()
    {
        XPosition = Random.Range(SpawnPosition.transform.position.x - 10, SpawnPosition.transform.position.x + 10);
        ZPosition = Random.Range(SpawnPosition.transform.position.z - 10, SpawnPosition.transform.position.z + 10);
        Instantiate(Enemy, new Vector3(XPosition, 6f, ZPosition), Quaternion.identity);
        EnemyCount++;
    }
}
