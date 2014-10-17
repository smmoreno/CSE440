using UnityEngine;
using System.Collections;

public class ZombieAnimator : MonoBehaviour {

	public Sprite[] sprites;
	public float framePerSecond;

	private SpriteRenderer spriteRenderer;


	// Use this for initialization
	void Start ()
	{
		spriteRenderer = renderer as SpriteRenderer;
	}
	
	// Update is called once per frame
	void Update ()
	{
		int index = (int)(Time.timeSinceLevelLoad * framePerSecond);
		index = index % sprites.Length;
		spriteRenderer.sprite = sprites [index];
	}
}
