using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class maze : MonoBehaviour {
	public float speed;
	float score=0;
	public float time;
	public GameObject CharacterController;
	CharacterController cc;
	public Text scoretext;
	public Text timetext;
	public Text TimeUptext;
	public GameObject panel;
	public GameObject image1;
	public GameObject image2;
	public GameObject image3;
	public bool panelactivebool;
	public bool finishline;
	public bool three;
	public bool two;
	public bool one;
	public bool timezero;
	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
		panel.SetActive (false);
		image1.SetActive (false);
		image2.SetActive (false);
		image3.SetActive (false);
		panelactivebool = false;
		finishline = false;
		one = false;
		two = false;
		three = false;
		timezero = false;
	}
	public void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Coin") {
			score++;
			Destroy (col.gameObject);
		} else if (col.gameObject.tag == "enemy") {
			score--;

			Destroy (col.gameObject);
			if (time >= 15f && time <= 20f) 
			{
				three = true;
				//image1.SetActive (true);
				//image2.SetActive (true);
				//image3.SetActive (true);
			} 
			else if (time >= 10 && time <= 14)
			{
				two = true;
				//image1.SetActive (true);
				//image2.SetActive (true);
			} 
			else if (time >= 1 && time <= 9)
			{
				one = true;
				//image1.SetActive (true);
			}
			TimeUptext.text = "Game Over";
			panelactivebool = true;
		} 
		else if (col.gameObject.tag == "Finish")
		{
			if (time >= 15f && time <= 20f) 
			{
				three = true;
				//image1.SetActive (true);
				//image2.SetActive (true);
				//image3.SetActive (true);
			} 
			else if (time >= 10 && time <= 14)
			{
				two = true;
				//image1.SetActive (true);
				//image2.SetActive (true);
			} 
			else if (time >= 1 && time <= 9)
			{
				one = true;
				//image1.SetActive (true);
			}
			TimeUptext.text = "Congratulations";
			finishline = true;

		}

	}

	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time > 0) 
		{
			if (panelactivebool == true)
			{
				if (one == true)
				{
					image1.SetActive (true);
				} 
				else if (two == true)
				{
					image1.SetActive (true);
					image2.SetActive (true);
				} 
				else if (three == true)
				{
					image1.SetActive (true);
					image2.SetActive (true);
					image3.SetActive (true);
				}
				timezero = true;
				panel.SetActive (true);
			} 
			else if (finishline == true)
			{
				if (one == true)
				{
					image1.SetActive (true);
				} 
				else if (two == true)
				{
					image1.SetActive (true);
					image2.SetActive (true);
				} 
				else if (three == true)
				{
					image1.SetActive (true);
					image2.SetActive (true);
					image3.SetActive (true);
				}
				timezero = true;
				panel.SetActive (true);
			}
			else
			{
				scoretext.text = "Score: " + score;
				timetext.text = "Time: " + (int)time;
				float h = Input.GetAxis ("Horizontal");
				float v = Input.GetAxis ("Vertical");
				Vector3 direction = new Vector3 (h, 0, v);
				Vector3 velocity = direction * speed;
				velocity = Camera.main.transform.TransformDirection (velocity);
				cc.Move (velocity * Time.deltaTime);
			}

		} 
		else if (time <= 0) 
		{
			if (timezero == false)
			{
				TimeUptext.text = "Time Up";
				image1.SetActive (true);
				panel.SetActive (true);
			}

		} 


	}
}
