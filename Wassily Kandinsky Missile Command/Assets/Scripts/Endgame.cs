﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject[] missiles = GameObject.FindGameObjectsWithTag("Missile");
        if (missiles.Length == 0)
        {
            Application.Quit();
        }
	}
}