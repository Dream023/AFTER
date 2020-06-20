using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPBar : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
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
        }
        CHP = Health;
        HP.text = "HP : " + CHP;
    }
}
