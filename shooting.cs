using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour {
	public GameObject bullet;
	public float speed;
	GameObject newbullet;
	// Use this for initialization
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			newbullet = Instantiate (bullet,transform.position,transform.rotation)as GameObject;
			Rigidbody rb = newbullet.GetComponent<Rigidbody> ();
			rb.AddForce (Vector3.right*speed);
			Destroy (newbullet,2f);

		}
		transform.rotation = Quaternion.LookRotation (Camera.main.transform.forward,Camera.main.transform.up);

	}
}
