using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{
    public Transform target;
	public Vector3 targetOffset = Vector3.zero;
	public float offset = 5.0f;
	public float rotationSpeed = 1.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		Vector3 relativePos = (target.position + targetOffset) - transform.position;

		Quaternion rotation = Quaternion.LookRotation(relativePos);
		Quaternion current = transform.localRotation;
		float relOffset = rotationSpeed * offset;
		transform.localRotation = Quaternion.Slerp(current, rotation, rotationSpeed* Time.deltaTime);
		transform.Translate(0, 0, relOffset* Time.deltaTime);
    }
}
