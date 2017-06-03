using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float moveSpeed;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey("d"))
        {
            rb.velocity = new Vector2(moveSpeed, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector2(-moveSpeed, 0);
        }

    }
    
}
