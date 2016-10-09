using UnityEngine;
using System.Collections;

public class CardboardScript : MonoBehaviour {
	public Rigidbody player;

	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		Jump ();
	}

	void Jump(){
		if (Input.GetButtonDown("Jump"))
			player.velocity = new Vector3(0, 5, 0);
	}
}
