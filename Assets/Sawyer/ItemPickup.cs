﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    [SerializeField]
    private Text pickUpText;
    public GameObject player;
    private bool pickUpAllowd;

    // Use this for initialization
    private void Start()  {
        pickUpText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()  {
        if (pickUpAllowd && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.name.Equals(player))

        if (collision.gameObject.name.Equals("Player"))

        if (collision.gameObject.name.Equals(player))

        if (collision.gameObject.name.Equals(player))

        {
            pickUpText.gameObject.SetActive(true);
            pickUpAllowd = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals(player))

        if (collision.gameObject.name.Equals("Player"))

        if (collision.gameObject.name.Equals(player))

        if (collision.gameObject.name.Equals(player))

        {
            pickUpText.gameObject.SetActive(false);
            pickUpAllowd = false;
        }
    }

    private void PickUp()
    {
        Destroy(gameObject);
    }

}
