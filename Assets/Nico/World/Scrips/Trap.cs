using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    //public GameObject spawnPoint;
    public GameObject mainPlayer;
    private Rigidbody2D rb2;
    public float knockBack;
    public bool negative;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.tag == "Player")
        {
            if (negative == true)
            {
                rb2 = mainPlayer.GetComponent<Rigidbody2D>();
                rb2.velocity = new Vector2(-knockBack, knockBack);
                //mainPlayer.transform.localPosition = spawnPoint.transform.localPosition;
            }
            else
            {
                rb2 = mainPlayer.GetComponent<Rigidbody2D>();
                rb2.velocity = new Vector2(knockBack, knockBack);
                //mainPlayer.transform.localPosition = spawnPoint.transform.localPosition;
            }
        }
    }



}