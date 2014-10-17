using UnityEngine;

public class CatUpdater : MonoBehaviour {
	
	private CatController catController;


	void OnBecameInvisible() {
		catController.OnBecameInvisible();
	}

	// Use this for initialization
	void Start () {
		catController = transform.parent.GetComponent<CatController>();  
	}

	void GrantCatTheSweetReleaseOfDeath()
	{
		Destroy( transform.parent.gameObject );
	}


	void UpdateTargetPosition()
	{
		catController.UpdateTargetPosition();
	}
}