using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nucleon : MonoBehaviour {

    public float attractionForce;

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        rb.AddForce(transform.localPosition * -attractionForce);
    }
}
