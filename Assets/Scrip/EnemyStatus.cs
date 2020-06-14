﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStatus : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    [SerializeField] int InputExp, HP,EnemyAttack,EnemyDef,Heal;
    [SerializeField] Text EnemyCHP;
    int CHP;
    int ExpPoint;
    void Start()
    {
        CHP = HP;
        ExpPoint = InputExp;
    }
    private void Update()
    {
        EnemyCHP.text = "HP : " + CHP;
    }
    public void GetDamageEnemy(int Damage)
    {
        CHP -= Mathf.Clamp(CHP, 0,(Damage - EnemyDef));
       if (CHP <= 0)
        {
            EnemyCHP.text = "HP : 0";
            Die();
        }
    }
    void Die()
    {
        Destroy(Enemy);
        PlayerStatus.Exp += ExpPoint;
        if (PlayerStatus.CHP<=PlayerStatus.MaxHp)
        {
            PlayerStatus.CHP += Heal;
        }
    }
    private void OnTriggerEnter(Collider Hit)
    {
        if (Hit.name == "Atomata")
        {
            PlayerStatus Damage = Hit.GetComponent<PlayerStatus>();
            if (Damage != null)
            {
                Damage.GetDamagePlayer(EnemyAttack);
            }
        }
    }
}