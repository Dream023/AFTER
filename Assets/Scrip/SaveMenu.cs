using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMenu : MonoBehaviour
{
    [SerializeField] GameObject SaveUI;
    int i=0;
    void Start()
    {
        SaveUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            i++;
            if(i%2==1)
            {
                SaveUI.SetActive(true);
                management.IsMove = false;
            }
            else if (i % 2 == 0)
            {
                SaveUI.SetActive(false);
                management.IsMove = true;
            }
        }
    }
}
