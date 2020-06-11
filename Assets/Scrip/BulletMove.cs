using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BulletMove : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int AttackDamage;
    bool isHitEnemy;
    private void Start()
    {
        AttackDamage = PlayerStatus.PlayerDamage;
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
        if (Hit.name=="EnemyCollider")
        {
                EnemyStatus Damage = Hit.GetComponent<EnemyStatus>();
                if (Damage != null)
                {
                    Damage.GetDamageEnemy(PlayerStatus.PlayerDamage);
                    Destroy(gameObject);
                }
        }
        else if (Hit.name == "BossCollider")
        {
            BossStatus Damage = Hit.GetComponent<BossStatus>();
            if (Damage != null)
            {
                Damage.GetDamageBoss(PlayerStatus.PlayerDamage);
                Destroy(gameObject);
            }
        }
    }
}
