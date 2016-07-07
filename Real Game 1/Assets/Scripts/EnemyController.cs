using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {



	public GameObject player;
	public float moveSpeed;


	// Use this for initialization
	void FixedUpdate () {
		transform.position = Vector3.MoveTowards (transform.position, player.transform.position,
			moveSpeed);
	
	}

}