using UnityEngine;
using System.Collections;


public class SpriteMove : MonoBehaviour {

	public float moveSpeed = 0.05f;

	public float jumpForce = 350f;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		//var movement = Vector3.zero;
		Vector3 tempPosition = transform.position;
		if (Input.GetAxis ("Horizontal") > 0) {
			tempPosition.x += moveSpeed;
			//transform.position += 0.5f;
		}
		if (Input.GetAxis ("Horizontal") < 0) {
			tempPosition.x -= moveSpeed;
		}
/*		if (Input.GetAxis ("Vertical") > 0) {
			tempPosition.y += moveSpeed;
		}
		if (Input.GetAxis ("Vertical") < 0) {
			tempPosition.y -= moveSpeed;
		}
*/		

		if(Input.GetKeyDown(KeyCode.Space))        //if we press spacebar
		{
			rigidbody2D.AddForce(new Vector2(0f, jumpForce)); 

			//jump();       //add force upwards (jump) and * the ammount by our jumpForce Variable
		}

		transform.position = tempPosition;
	

	}
	


}
