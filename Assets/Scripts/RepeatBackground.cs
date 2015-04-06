using UnityEngine;
using System.Collections;

public class RepeatBackground : MonoBehaviour 
{ 
	public float increment;

	void OnBecameInvisible()
	{
		//calculate current position
		Vector3 position = gameObject.transform.position;
		//calculate new position
		float newX = position.x + increment;
		//move to new position when invisible
		gameObject.transform.position = new Vector3 (newX, position.y, 0f);
	}
}
