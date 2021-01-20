﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject mainPlayer;
    private Rigidbody2D rb2;
    public float knockBack;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
            rb2 = mainPlayer.GetComponent<Rigidbody2D>();
            rb2.velocity = new Vector2(0, 0);
            mainPlayer.transform.localPosition = spawnPoint.transform.localPosition;



        }
    }



}