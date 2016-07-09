using UnityEngine;
using System.Collections;

public class WaffleController: MonoBehaviour {
	public GameObject ShrekSound;
	public float Speed;
	void FixedUpdate(){
		gameObject.transform.Rotate (Vector3.up * Speed);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			ShrekSound.GetComponent<AudioSource> ().Stop ();
			ShrekSound.GetComponent<AudioSource> ().Play ();
			GameObject.Destroy (gameObject);
			GameObject.Destroy (this);
		}
	  }
	}

		