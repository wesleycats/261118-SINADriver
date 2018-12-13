﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOptions : MonoBehaviour {

    public GameObject pauseMenu;
	public InputManager inputScript;

	private bool gamePaused = false;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused) Resume(pauseMenu);
            else Pause(pauseMenu);
        }
	}

	public void Retry()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

    public void Resume(GameObject menu)
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void Pause(GameObject menu)
    {
        menu.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public bool GetGamePaused() { return gamePaused; }
}