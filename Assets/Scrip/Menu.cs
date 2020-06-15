using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject MenuScenes;
    void Start()
    {
        MenuScenes.SetActive(true);
    }
    void Update()
    {
        if (management.IsMenu == false)
        {
            MenuScenes.SetActive(false);
        }
        else if (management.IsMenu == true)
        {
            MenuScenes.SetActive(true);
        }
    }
    public void StartGame()
    {
        management.IsMenu = false;
        management.IsMove = true;
        return;
    }
    public void SaveMenu()
    {

    }
}
