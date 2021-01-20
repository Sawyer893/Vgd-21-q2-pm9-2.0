﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMove : MonoBehaviour
{
    public float accel = 8;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;
    private Inventory inventory;
    private Animator Anim;

    private void Awake()
    {
        inventory = new Inventory();
        Anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update.
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        
        //move right
        if(Input.GetAxis("Horizontal")> 0)
        {

            sr.flipX = true;
            rb2.AddForce(new Vector2(accel, 0));
        }
        //move left
        if (Input.GetAxis("Horizontal") < 0)
        {

            sr.flipX = false;
            rb2.AddForce(new Vector2(-accel, 0));

            Anim.SetFloat("Velocity X", Mathf.Abs(rb2.velocity.x));
                
        }
    }
}

