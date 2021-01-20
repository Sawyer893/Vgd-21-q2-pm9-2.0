using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour


{
    public float speed = 5f;
    private Rigidbody2D rb2;
    private Animator anim;
    private SpriteRenderer sr;

    private void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }
  
    private void Update()
    {
        rb2.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb2.velocity.y);
        anim.SetFloat("Velocity X", Mathf.Abs(rb2.velocity.x));
        if (rb2.velocity.x > 0f)
            sr.flipX = true;
        else if (rb2.velocity.x < 0f)
            sr.flipX = false;
    
    }


}
