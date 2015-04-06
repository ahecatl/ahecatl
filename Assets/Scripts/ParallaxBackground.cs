using UnityEngine;
using System.Collections;

public class ParallaxBackground : MonoBehaviour {
	public float scrollFactor;

	private Transform m_cameraTransform;
	private Vector3 m_lastTargetPosition;

	private void Start() {
		m_cameraTransform = Camera.allCameras [0].transform;
		m_lastTargetPosition = m_cameraTransform.position;
	}

	private void Update() {
		float deltaX = m_cameraTransform.position.x - m_lastTargetPosition.x;
		m_lastTargetPosition = m_cameraTransform.position;

		Vector3 position = transform.position;
		transform.position = new Vector3 (position.x + deltaX * scrollFactor, position.y, position.z);
	}
}
