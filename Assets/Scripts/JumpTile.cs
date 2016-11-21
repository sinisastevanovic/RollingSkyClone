﻿using UnityEngine;
using System.Collections;
using Vector3DNamespace;

public class JumpTile : MonoBehaviour {

    private GameObject player;
    private CubeCollider myCollider;
    private Vector3D myPos;
    private Vector3D target;

    public float modifier = 0.3f;
    public float speed = 50f;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        myCollider = this.GetComponent<CubeCollider>();
        

    }
	
	// Update is called once per frame
	void Update () {
	    if(myCollider.myCollider.AABBtoAABB(player.GetComponent<CubeCollider>().myCollider))
        {
            myPos = new Vector3D(transform.position.x, transform.position.y, transform.position.z);
            target = new Vector3D(transform.position.x, modifier, transform.position.z);
            transform.position = Vector3D.Lerp(myPos, target, speed * Time.deltaTime);
            //transform.position = new Vector3D(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
            player.GetComponent<PlayerMovement>().goJump = true;
        }
	}
}
