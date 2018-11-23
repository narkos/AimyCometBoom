using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouseController : MonoBehaviour {

	private Vector3 _nextPosition;
	
	[SerializeField] private float _moveSpeed = 0.1f;

	void Start() {
		_nextPosition = transform.position;
	}

	void Update () {
		float distance = transform.position.z - Camera.main.transform.position.z;
		_nextPosition = new Vector3(Input.mousePosition.x, distance, Input.mousePosition.y);
		_nextPosition = Camera.main.ScreenToWorldPoint(_nextPosition);

		transform.position = Vector3.Lerp(transform.position, _nextPosition, _moveSpeed * Time.deltaTime);
	}
}
