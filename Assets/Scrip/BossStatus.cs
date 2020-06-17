using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossStatus : MonoBehaviour
{
    [SerializeField] GameObject Boss,Door;
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
        if (CHP <= 0)
        {
            BossCHP.text = "HP : 0";
            Die();
        }
    }
    void Die()
    {
        Destroy(Boss);
        PlayerStatus.Exp += ExpPoint;
        Destroy(Door);
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
