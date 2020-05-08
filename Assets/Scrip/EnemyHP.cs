using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    public int HP = 50;
    int CHP;
    void Start()
    {
        CHP = HP;
    }
    public void TakeDamage(int Damage)
    {
        CHP -= Damage;
        if (CHP <=0)
        {
            Die();
        }
    }
    void Die()
    {
        GameObject.Destroy(Enemy);
    }
}
