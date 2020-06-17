using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsAnimation : MonoBehaviour
{
    [SerializeField] Animator MainCharecter;
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            MainCharecter.SetBool("IsRun", true);
            MainCharecter.SetBool("IsIdle", false);
        }
        else
        {
            MainCharecter.SetBool("IsRun", false);
            MainCharecter.SetBool("IsIdle", true);
        }
    }
}
