using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData : MonoBehaviour
{
    public int CHP2, PlayerDamage2, Exp2, MaxHp2, Level2, ExpToNextLevel, playerDef;
    public float[] position;

    public PlayerData (PlayerStatus player)
    {
        CHP2 = player.CHP2;
        PlayerDamage2 = player.PlayerDamge2;
        Exp2 = player.Exp2;
        MaxHp2 = player.MaxHp2;
        Level2 = player.Level2;
        ExpToNextLevel = player.ExpToNextLevel;
        playerDef = player.playerDef;
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }

}
