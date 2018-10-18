using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour {

    public float speed = 5.0f;


    void Start()
    {
       
    }

    void Update()
    {
        transform.Translate(-speed *Time.deltaTime, 0, 0);
    }
}
