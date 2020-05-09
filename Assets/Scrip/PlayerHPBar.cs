using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHPBar : MonoBehaviour
{
    [SerializeField] Collider Enemy;
    int Health,CHP;
    [SerializeField] Text HP;
    private void Start()
    {   
        Health = 140;
        CHP = Health;
        HP.text = "HP : " + CHP;
    }
    private void OnTriggerEnter(Collider Enemy)
    {
        Health -= 20;
        if (Health<=0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Dead");

        }
        CHP = Health;
        HP.text = "HP : " + CHP;
    }
    
}
