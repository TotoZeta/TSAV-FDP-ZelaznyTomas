using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{
    bool pause;
    public GameObject pausePanel;
    void Start()
    {
        PauseOff();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(pause == true)
            {
                PauseOff();
            }
            if(pause == false)
            {
                PauseOn();
            }
        }
    }

    public void ChangeScene()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        int EscenaMenu = 0;
        int Escena1 = 1;

        if (CurrentScene.name == "Escena 1")
        {
            SceneManager.LoadScene(EscenaMenu);
        }
        if (CurrentScene.name == "Main Menu")
        {
            SceneManager.LoadScene(Escena1);
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void PauseOn()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        pause = true;
    }
    public void PauseOff()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        pause = false;
    }
}
