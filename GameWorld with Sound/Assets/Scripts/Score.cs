using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour 
{
	public AudioClip Coin;
	public int increment = 10;
		
	void OnCollisionEnter2D(Collision2D other) 
	{
		if (other.gameObject.tag == "Player") 
		{
			GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteMove>().score += increment;

			GameObject.FindGameObjectWithTag("Score").GetComponent<GUIText>().text = 
				GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteMove>().score.ToString();

			gameObject.audio.PlayOneShot (Coin);
		}
	}
}