using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemydisappear : MonoBehaviour {
	//public GameObject panel1;
	//public Text GameOverText;
	// Use this for initialization
	void Start () {
		//panel1.SetActive (false);
	}
	public void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.tag == "enemy")
		{
			
			Destroy (collider.gameObject);
		}
		if (collider.gameObject.tag == "door") 
		{
			Destroy (collider.gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
