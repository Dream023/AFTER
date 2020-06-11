using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour
{
    static public int CHP, PlayerDamage, Exp, Level;
    int Hp, ExpToNextLevel,playerDef;
    [SerializeField] Text PlayerHP,PlayerLevel;
    void Start()
    {
        Hp = 100;
        CHP = Hp;
        Level = 1;
        ExpToNextLevel = 20;
        PlayerDamage = 10;
        Exp = 0;
        playerDef = 0;
    }
    void Update()
    {
        PlayerHP.text = "HP : " + CHP;
        PlayerLevel.text = "LV." + Level;
        if (CHP <= 0)
        {
            Die();
            SceneManager.LoadScene("Dead");
        }
        else if (Exp >= ExpToNextLevel)
        {
            Level++;
            Hp += 10;
            PlayerDamage += 1;
            Exp = 0;
            ExpToNextLevel = 0;
            ExpToNextLevel = 20 * Level;
            CHP = Hp;
            if (Level%5==0)
            {
                playerDef++;
            }
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
    public void GetDamagePlayer(int Damage)
    {
        CHP -= Mathf.Clamp(CHP,0, (Damage - playerDef));
        return;
    }
}
