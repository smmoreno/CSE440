using UnityEngine;
using System.Collections;

public class ObstacleCollision2 : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.tag == "Player")
			transform.Translate (2, 0, 0);	
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
