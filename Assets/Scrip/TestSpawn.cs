using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSpawn : MonoBehaviour
{
    [SerializeField] AudioClip SpawnSound;
    [SerializeField] GameObject Enemy,SpawnPosition;
    public float XPosition, ZPosition;
    static public float EnemyCount;
    [SerializeField] float LimitSpawn;
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
            if (EnemyCount < LimitSpawn)
            {
                StartCoroutine(SpawnDelay());
            }
            AudioSource.PlayClipAtPoint(SpawnSound, gameObject.transform.position);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.name == "MainCharecter")
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies)
            Destroy(enemy);
            EnemyCount = 0;
        }
    }
    void Spawn()
    {
        XPosition = Random.Range(SpawnPosition.transform.position.x - 10, SpawnPosition.transform.position.x + 10);
        ZPosition = Random.Range(SpawnPosition.transform.position.z - 10, SpawnPosition.transform.position.z + 10);
        Instantiate(Enemy, new Vector3(XPosition, gameObject.transform.position.y+1, ZPosition), Quaternion.identity);
        EnemyCount++;
    }
}
