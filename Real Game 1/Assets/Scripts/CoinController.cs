using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {
	public float Speed;
	void FixedUpdate(){
		gameObject.transform.Rotate (Vector3.up * Speed);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.tag == "Player") {
			GameObject.Destroy (gameObject);
		}
	}











}