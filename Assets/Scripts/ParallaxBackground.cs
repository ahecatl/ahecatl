using UnityEngine;
using System.Collections;

public class ParallaxBackground : MonoBehaviour {
	public float scrollFactor;
	public Transform trackingCamera;

	private Vector3 m_lastTargetPosition;

	private void Start() {
		m_lastTargetPosition = trackingCamera.position;
	}

	private void Update() {
		float deltaX = trackingCamera.position.x - m_lastTargetPosition.x;
		m_lastTargetPosition = trackingCamera.position;

		Vector3 position = transform.position;
		transform.position = new Vector3 (position.x + deltaX * scrollFactor, position.y, position.z);
	}
}
