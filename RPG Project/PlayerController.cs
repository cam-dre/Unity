using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    //=====COLLIDERS=====
    public GameObject feet = null;

    //=====MOVEMENT=====
    // Key Mapping
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;

    // Movement Stats
    public float speed = 5.0f;

    public float jump = 5.0f;
    public bool canJump = true;
    public bool isJumping = false;
    public bool isOnGround = true;
    public float jumpTimer = 0.0f;
    public float maxJumpTime = 5.0f;

    public float fallThrough = 2.0f;


	// Use this for initialization
	void Start () {
        canJump = true;
        isJumping = false;
        jumpTimer = 0.0f;
		isOnGround = true;
	}
	
	// Update is called once per frame
	void Update () {
        //=====MOVEMENT=====
        // Up
        if(Input.GetKeyDown(up)) {
            print("Up key is being pressed.");
            canJump = false;
            isOnGround = false;
        }
		if(Input.GetKey(up)) {
            print("Up key is being held down.");
            if(jumpTimer <= maxJumpTime) { // if total jump time is not more than maxJumpTime
                gameObject.transform.Translate(Vector3.up * Time.deltaTime * jump);
                jumpTimer += Time.deltaTime;
            }
            else { // if jump time exceeds maxJumpTime
                isJumping = false;
                jumpTimer = 0.0f;
            }
        }
        if(Input.GetKey(up)) {
            canJump = true;
            isJumping = false;
            jumpTimer = 0.0f;
        }
        // Down
        if(Input.GetKeyDown(down)) {
            gameObject.transform.Translate(Vector3.down * fallThrough);
        }
        // Left
        if(Input.GetKey(left)) {
            gameObject.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        // Right
        if(Input.GetKey(right)) {
            gameObject.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
	}


}
