using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMenu : MonoBehaviour
{
    static public bool IsSaveMenu = false;
    [SerializeField] GameObject SaveMenuUI;
    private void Start()
    {
        SaveMenuUI.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(IsSaveMenu)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        SaveMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsSaveMenu = false;
        management.IsMove = true;
    }
    void Pause()
    {
        SaveMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsSaveMenu = true;
    }
}
