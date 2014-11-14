using UnityEngine;
using System.Collections;

public class ObstacleCollision : MonoBehaviour {

	public float SwitchTime = 1.0f;
	public float Speed = 0.5f;
	public bool movedown = false;

	void OnCollisionEnter2D(Collision2D coll) 
	{
		if (coll.gameObject.tag == "SwitchTrigger")
			transform.Translate (0, 0, 0);	
			StartCoroutine(Switch());
	}


	IEnumerator Switch()
	{
		while (true)
			{
				yield return new WaitForSeconds (SwitchTime);
			movedown = !movedown;
			}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (movedown) 
		{
			transform.position += Vector3.down * Speed * Time.deltaTime;
		} else {
			transform.position += Vector3.up * Speed * Time.deltaTime;
		}
	}
}
