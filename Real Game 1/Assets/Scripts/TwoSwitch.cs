using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class TwoSwitch : MonoBehaviour {
	public GameObject Coin;
	public string nextLevel;
	// Update is called once per frame
	void Update () {

		if (GameObject.FindWithTag ("Coin") == null) {
			SceneManager.LoadScene (nextLevel);
		}


	}
}
