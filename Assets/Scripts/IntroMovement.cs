using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMovement : MonoBehaviour {

    Rigidbody rb;

    [SerializeField] float moveSpeed = 1.6f;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(moveSpeed, 0, 0);
	}
}
