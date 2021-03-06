﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossStatus : MonoBehaviour
{
    [SerializeField] AudioClip Break,GetHit;
    [SerializeField] GameObject Boss,Break1,Break2,Break3,Break4;
    [SerializeField] int InputExp, HP, BossAttack, BossDef;
    [SerializeField] Text BossCHP;
    int CHP;
    int ExpPoint;
    void Start()
    {
        CHP = HP;
        ExpPoint = InputExp;
    }
    private void Update()
    {
        BossCHP.text = "HP : " + CHP;
    }
    public void GetDamageBoss(int Damage)
    {
        CHP -= Mathf.Clamp(CHP, 0,Mathf.Max(0, (Damage - BossDef)));
        AudioSource.PlayClipAtPoint(GetHit, gameObject.transform.position);
        if (CHP <= 0)
        {
            Die();
        }
        switch (CHP)
        {
            case 0:
                Die();
                break;
        }
    }
    void Die()
    {
        if (Boss.name == "Boss5")
        {
            SceneManager.LoadScene("EndCut");
        }
        Destroy(Boss);
        PlayerStatus.Exp += ExpPoint;
        Destroy(Break1);
        Destroy(Break2);
        Destroy(Break3);
        Destroy(Break4);
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        Destroy(enemy);
        TestSpawn.EnemyCount = 0;
        AudioSource.PlayClipAtPoint(Break, gameObject.transform.position);
    }
    private void OnTriggerEnter(Collider Hit)
    {
        if (Hit.name == "MainCharecter")
        {
            PlayerStatus Damage = Hit.GetComponent<PlayerStatus>();
            if (Damage != null)
            {
                Damage.GetDamagePlayer(BossAttack);
            }
        }
    }
}
