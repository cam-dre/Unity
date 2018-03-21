using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerah : MonoBehaviour 
{

	public GameObject CameraDock;
	public float followSpeed;
	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		transform.position = Vector3.Lerp (transform.position, CameraDock.transform.position, followSpeed);
	}
}

