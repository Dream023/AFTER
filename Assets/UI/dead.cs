using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    public void Dead()
    {
        SceneManager.LoadScene("menu");
    }
}
