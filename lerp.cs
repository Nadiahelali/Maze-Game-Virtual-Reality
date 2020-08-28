using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class lerp : MonoBehaviour {
	public Transform initialPosition;
	public  Transform endPosition;
	Transform x;
	Transform y;
	//public GameObject[] destination;
	//public float duration;
	//public float distance;
	float currentdist;
	public float speed;
	float dist;
	int current=0;
	bool initial;
	bool end;



	// Use this for initialization
	void Start () {
		//currenttime = Time.time;
		x=initialPosition;
		y = endPosition;
		dist = Vector3.Distance (initialPosition.position,endPosition.position);
		initial = true;
		end = false;
	

	}

	float fracdist;
	// Update is called once per frame
	void Update () {


			currentdist += Time.deltaTime*speed;
			fracdist = currentdist / dist;
		//dist=Vector3.Distance (destination [current].transform.position, transform.position);
		//Debug.Log("Distance: " + distance + ", frac: " + fracdist);

		if (Vector3.Distance (y.position, transform.position) <.01f)
		{
			if (initial == true)
			{
				x = endPosition;
				y = initialPosition;
				end = true;
				initial = false;
			}
			else if (end == true)
			{
				x = initialPosition;
				y = endPosition;
				initial = true;
				end = false;
			}
			/*current++;
			if (current >= destination.Length) {
				current = 0;
			}*/

			currentdist = 0f;
			fracdist = 0f;
		}
	
		transform.position = Vector3.Lerp (x.position,y.position,fracdist);

			



	}
}
