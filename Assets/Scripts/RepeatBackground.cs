using UnityEngine;
using System.Collections;

public class RepeatBackground : MonoBehaviour 
{ 
	public float increment;

	private Transform m_cameraTransform;

	private void Start(){ 
		m_cameraTransform = Camera.allCameras [0].transform;
	}

	private void Update() {
		Vector3 position = gameObject.transform.position;
		float delta = m_cameraTransform.position.x - position.x;

		if (Mathf.Abs (delta) > increment / 2) {
			float newX = position.x + increment * Mathf.Sign(delta);
			gameObject.transform.position = new Vector3 (newX, position.y, 0f);
		}
	}
}
