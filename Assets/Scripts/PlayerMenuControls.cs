using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMenuControls : MonoBehaviour
{

    public bool isPaused = false;

    GameObject[] SettingsUIElements;
    GameObject[] PauseUIElements;

    // Start is called before the first frame update
    void Awake()
    {

        SettingsUIElements = GameObject.FindGameObjectsWithTag("SettingsMenu");
        hideSettingsUI();

        PauseUIElements = GameObject.FindGameObjectsWithTag("PauseMenu");
        hidePauseUI();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("escape"))
        {

            if (isPaused == false)
            {

                Time.timeScale = 0;

                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

                showPauseUI();
                isPaused = true;

            }

        }

    }

    void hideSettingsUI()
    {

        foreach (GameObject u in SettingsUIElements)
        {

            u.SetActive(false);

        }

    }

    void showSettingsUI()
    {

        foreach (GameObject u in SettingsUIElements)
        {

            u.SetActive(true);

        }

    }

    void hidePauseUI()
    {

        foreach (GameObject u in PauseUIElements)
        {

            u.SetActive(false);

        }

    }

    void showPauseUI()
    {

        foreach (GameObject u in PauseUIElements)
        {

            u.SetActive(true);

        }

    }

    public void Resume() { hidePauseUI(); hideSettingsUI(); Cursor.visible = false; Cursor.lockState = CursorLockMode.Locked; Time.timeScale = 1; isPaused = false; Debug.Log("Resumed!"); }

    public void Return() { hideSettingsUI(); showPauseUI(); }

    public void SettingsMenu() { hidePauseUI(); showSettingsUI(); }

    public void MainMenu() { SceneManager.LoadScene("LevelSelect"); }

    public void Exit() { Application.Quit(); }

}
