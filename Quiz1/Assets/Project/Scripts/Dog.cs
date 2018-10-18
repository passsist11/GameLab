using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour {

    public float jumping;

	
	// Update is called once per frame
	private void Update () {

        if (Input.GetKeyDown (KeyCode.Space)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumping);
        }
		
	}
}
