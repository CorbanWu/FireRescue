using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float jumpHeight;
    public float moveSpeed;
    public Rigidbody2D rb;
    private bool isGrounded = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKeyDown("space"))
        {
            if (isGrounded == true)
            {
                rb.AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
                isGrounded = false;
            }
        }
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(moveSpeed, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
