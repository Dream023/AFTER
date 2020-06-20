using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : MonoBehaviour
{
    public Transform AttackPoint;
    public float AttackRange = 0.5f;
    int AttackDamage = 20;
    [SerializeField] LayerMask EnemyLayers;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
    void Attack()
    {
        Collider[] HitEnemy = Physics.OverlapSphere(AttackPoint.position, AttackRange, EnemyLayers);
        foreach (Collider Enemy in HitEnemy)
        {
            Enemy.GetComponent<EnemyHP>().TakeDamage(AttackDamage);
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (AttackPoint == null)
            return;
        Gizmos.DrawWireSphere(AttackPoint.position, AttackRange);
    }
}
