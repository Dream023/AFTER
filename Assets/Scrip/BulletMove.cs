using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int AttackDamage;
    private void Start()
    {
        AttackDamage = 20;
    }
    void Update()
    {
        transform.Translate(0f,speed*Time.deltaTime,0f); 
        if(transform.position.z>=50||transform.position.z<=-50)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x >= 50||transform.position.x<=-50)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider Hit)
    {
        EnemyHP enemy = Hit.GetComponent<EnemyHP>();
        if (enemy != null)
        {
            enemy.TakeDamage(AttackDamage);
        }
        Destroy(gameObject);
    }
}
