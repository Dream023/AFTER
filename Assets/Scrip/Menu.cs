using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject MenuScenes;
    [SerializeField] GameObject All;
    [SerializeField] GameObject Cut;
    void Start()
    {
        MenuScenes.SetActive(true);
        Cut.SetActive(false);
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
        All.SetActive(false);
        management.IsMenu = false;
        
    }
    public void SaveMenu()
    {

    }
    public void Skip()
    {
        Cut.SetActive(false);
        All.SetActive(true);
        management.IsMove = true;
        return;
    }
    public void Quit()
    {
        Debug.Log("END");
        Application.Quit();
    }

}
