﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackGround : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed =-2f;
    public float lowerYValue =-20f;
    public float upperYValue =40;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f,speed*Time.deltaTime,0f);
        if(transform.position.y<=lowerYValue){
            transform.Translate(0f,upperYValue,0f);
        }
    }
}
