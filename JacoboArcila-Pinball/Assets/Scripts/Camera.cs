using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	public GameObject ball;
	private Vector3 offset;


	// Use this for initialization
	void Start () {
		offset = transform.position - ball.transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		transform.position = ball.transform.position + offset;

	}
}
