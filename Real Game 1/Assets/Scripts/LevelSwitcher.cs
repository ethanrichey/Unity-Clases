﻿using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class LevelSwitcher : MonoBehaviour {

	public string nextLevel;
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.Return)) {
			SceneManager.LoadScene (nextLevel);
		}
			

	}
}
