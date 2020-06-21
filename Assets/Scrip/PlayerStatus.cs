using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStatus : MonoBehaviour
{
    [SerializeField] AudioClip GetHit;
    [SerializeField] GameObject Menu,SaveMenu, PlayerPosition;
    static public int CHP, PlayerDamage, Exp, MaxHp, Level;
    public int ExpToNextLevel,playerDef;
    
    public int CHP2 = CHP;
    public int PlayerDamge2 = PlayerDamage;
    public int Exp2 = Exp;
    public int MaxHp2 = MaxHp;
    public int Level2 = Level;
    public GameObject PlayerPosition2;
   


    [SerializeField] Text PlayerHP,PlayerLevel;
    public void Start()
    {
        MaxHp = 100;
        CHP = MaxHp;
        Level = 1;
        ExpToNextLevel = 20;
        PlayerDamage = 10;
        Exp = 0;
        playerDef = 0;
    }
   public void Update()
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
            MaxHp += 10;
            PlayerDamage += 1;
            Exp = Exp-ExpToNextLevel;
            ExpToNextLevel = 0;
            ExpToNextLevel = 20 * Level;
            CHP = MaxHp;
            if (Level%5==0)
            {
                playerDef++;
            }
        }
        else if (CHP >= MaxHp)
        {
            CHP = MaxHp;
        }
         CHP2 = CHP;
         PlayerDamge2 = PlayerDamage;
         Exp2 = Exp;
         MaxHp2 = MaxHp;
        Level2 = Level;
        PlayerPosition2 = PlayerPosition;




}
    void Die()
    {
        Destroy(gameObject);
    }
    public void GetDamagePlayer(int Damage)
    {
        CHP -= Mathf.Clamp(CHP,0, (Damage - playerDef));
        AudioSource.PlayClipAtPoint(GetHit, gameObject.transform.position);
        return;
    }

    public void SavePlayer()
    {
        Debug.Log("Save");
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        Menu.SetActive(false);
        SaveMenu.SetActive(false);
        management.IsMenu = true;
        management.IsMove = true;
        Time.timeScale = 1f;
        TestSpawn.EnemyCount = 0;

        PlayerData data = SaveSystem.LoadPlayer();
        CHP = data.CHP2;
        PlayerDamage = data.PlayerDamage2;
        Exp = data.Exp2;
        MaxHp = data.MaxHp2;
        Level = data.Level2;
        ExpToNextLevel = data.ExpToNextLevel;
        playerDef = data.playerDef;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        PlayerPosition.transform.position = position;


    }


}
