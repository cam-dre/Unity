using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour 
{	
	public int moveSpeed;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.W)) 
		{
			gameObject.transform.Translate (Vector3.down * Time.deltaTime * moveSpeed);
		}
		else if (Input.GetKey(KeyCode.S)) 
		{
			gameObject.transform.Translate (Vector3.up * Time.deltaTime * moveSpeed);
		}
		else if (Input.GetKey(KeyCode.A)) 
		{
			gameObject.transform.Translate (Vector3.right * Time.deltaTime * moveSpeed);
		}
		else if (Input.GetKey(KeyCode.D)) 
		{
			gameObject.transform.Translate (Vector3.left * Time.deltaTime * moveSpeed);
		}
	}
}
