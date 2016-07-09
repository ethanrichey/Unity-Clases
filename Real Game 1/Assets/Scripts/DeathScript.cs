using UnityEngine.SceneManagement;
using UnityEngine;
using System.Collections;

public class DeathScript : MonoBehaviour {
	public string nextLevel;


	void OnTriggerEnter(Collider col) {
		Debug.Log ("Collided");
		if (col.gameObject.tag == "Enemy") {
			SceneManager.LoadScene (nextLevel);
			Debug.Log ("Detected");
		}
	


	}
}
