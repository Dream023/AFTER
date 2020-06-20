using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIsTarget : MonoBehaviour
{
    #region Singleton
    public static PlayerIsTarget inatance;
    void Awake()
    {
        inatance = this;
    }
    #endregion
    [SerializeField] public GameObject Player;
}
