using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank_Movement : MonoBehaviour {

    public float speed = 5;
    public float angularSpeed = 0.5f;
    public float number = 1;

    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        float v = Input.GetAxis("VerticalP"+number);
        rigidbody.velocity = transform.forward * v * speed;

        float h = Input.GetAxis("HorizontalP"+number);
        rigidbody.angularVelocity = transform.up * h * angularSpeed;
	}
}
