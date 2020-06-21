using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossStatus : MonoBehaviour
{
    [SerializeField] AudioClip Break,GetHit;
    [SerializeField] GameObject Boss,Door1,Door2;
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
            BossCHP.text = "HP : 0";
            Die();
        }
    }
    void Die()
    {
        if (Boss.name == "Boss5")
        {
            SceneManager.LoadScene("Dead");
        }
        Destroy(Boss);
        PlayerStatus.Exp += ExpPoint;
        Destroy(Door1);
        Destroy(Door2);
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
