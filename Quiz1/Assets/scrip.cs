using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrip : MonoBehaviour{
    public float speed = 5.0f;


    void Update ()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }





    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Dog")
        {
            scoreScript.scoreValue += 10;


        }


    }

}
