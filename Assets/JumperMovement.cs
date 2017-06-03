using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperMovement : MonoBehaviour {

    public float dropSpeed;
    public Rigidbody2D rigidJumper;
    private float intX;
    private float intY;
    private bool stopped;

    // Use this for initialization
    void Start () {
        intX = rigidJumper.position.x;
        intY = rigidJumper.position.y;
        stopped = true;

    }

    // Update is called once per frame
    void Update () {
        print(stopped);
        if (stopped == false){ 
            rigidJumper.velocity = new Vector2(0,-dropSpeed);
        }

    }

    public float getDropSpeed()
    {
        return dropSpeed; 
    }

    public void setDropSpeed(float x)
    {
        dropSpeed = x;
    }


    public bool getStopped()
    {
        return stopped;
    }


    public void setStopped(bool x)
    {
        stopped = x;
    }

    void OnCollisionEnter2D(Collision2D coll)

    {
    
        if (coll.gameObject.tag == "Player")
        {
            rigidJumper.position = new Vector2(intX, intY);
            rigidJumper.velocity = new Vector2(0, 0);
            stopped = true;
        }
        if (coll.gameObject.tag == "Ground")
        {
            print("Game Over");
            rigidJumper.velocity = new Vector2(0, 0);
        }
    }
}
