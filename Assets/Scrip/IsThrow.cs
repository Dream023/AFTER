using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsThrow : MonoBehaviour
{
    [SerializeField] Animator MainCharecter;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            MainCharecter.SetBool("IsThrow", true);
            
        }
        else
            MainCharecter.SetBool("IsThrow", false);
    }
}
