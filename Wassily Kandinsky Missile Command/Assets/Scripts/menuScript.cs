﻿using UnityEngine;
using System.Collections;

public class menuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    //Load the main level scene
    public void ClickPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("GameScene");
    }

    //Load the credits level
    public void ClickCredits()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("CreditsScene");
    }

    //Return to the main menu
    public void ClickBack()
    {
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("MenuScene");
    }
    
    //Exit the application
    public void ClickExit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update () {
	
	}
}
