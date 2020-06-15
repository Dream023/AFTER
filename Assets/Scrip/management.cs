using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class management : MonoBehaviour
{
    static public bool IsMove, IsMenu,IsSave;
    void Start()
    {
        IsMenu = true;
        IsMove = false;
        IsSave = false;
    }
}
