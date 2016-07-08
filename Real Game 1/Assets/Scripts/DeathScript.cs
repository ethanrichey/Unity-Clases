using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour {
	public string nextLevel;


	void OnCollisionEnter(Collision col) {

		if (col.gameObject.tag == "Enemy") {
			SceneManager.LoadScene (nextLevel);
		}


	}
}
