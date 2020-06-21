using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject MenuScenes;
    [SerializeField] GameObject All;
    [SerializeField] GameObject Cut;
    [SerializeField] GameObject video;
    
    void Start()
    {
        MenuScenes.SetActive(true);
        Cut.SetActive(false);
        Time.timeScale = 0f;
        video.SetActive(false);
    }
    void Update()
    {
        if (management.IsMenu == false)
        {
            MenuScenes.SetActive(false);
            Time.timeScale = 1f;
        }
        else if (management.IsMenu == true)
        {
            MenuScenes.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void StartGame()
    {
        All.SetActive(false);
        management.IsMenu = false;
        TestSpawn.EnemyCount = 0;
        video.SetActive(true);
        
        
        
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
