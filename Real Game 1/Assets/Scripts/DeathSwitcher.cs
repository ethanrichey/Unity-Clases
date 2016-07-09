using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class DeathSwitcher : MonoBehaviour {
	public string LevelScene;

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Return)) {
			SceneManager.LoadScene (LevelScene);
		}


	}
}
