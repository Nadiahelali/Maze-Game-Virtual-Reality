using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class newreticalpointer : MonoBehaviour {
	public  bool restart;
	public bool home;
	public float time;

	void Update(){
		if (restart) 
		{
			time -= Time.deltaTime;
			if (time < 0)
			{
				SceneManager.LoadScene ("1");

			}
		}
		else if (home) 
		{
			time -= Time.deltaTime;
			if (time < 0)
			{
				SceneManager.LoadScene ("homescene");

			}
		}

	}
	public void OnPointerEnter(){

		//Debug.Log ("up");
		restart = true;



		//timeMouseDown = 0;

	}
	public void OnClickHome()
	{
		home = true;
	}

	public void OnPointerExit(){
		///mouseDown = ;
		//Debug.Log ("down");
		//mouseDown = true;


	}

}