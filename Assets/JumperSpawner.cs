using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperSpawner : MonoBehaviour {

    public int spawnSpeed;

    // Use this for initialization
    void Start () {
	}

    // Update is called once per frame  
    void Update() {
        GameObject jumper = GameObject.Find("Jumper");
        JumperMovement jumperMovement = jumper.GetComponent<JumperMovement>();
        print(Time.renderedFrameCount % spawnSpeed);

        if (Time.renderedFrameCount % spawnSpeed == 0)
        {
            //if (Random.Range(1, 10) == 1)
            //{
                jumperMovement.setStopped(false);
            //}
        }
	}
    
}
