using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float accel = 8;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;
    private Inventory inventory;
    private Animator Anim;
    public float knockBack;
    public float knockbackLength;
    public float knockbackCount;
    public bool knockFromRight;

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
        if (Input.GetAxis("Horizontal") > 0)
            if (knockbackCount <=0)
        {

            sr.flipX = true;
            rb2.AddForce(new Vector2(accel, 0));
        }else if (knockFromRight)
            {
                rb2.velocity = new Vector2(-knockBack, knockBack);
            }
        else if (!knockFromRight)
            {
                rb2.velocity = new Vector2(knockBack, knockBack);
            }
        knockbackCount -= Time.deltaTime;

        //move left
        if (Input.GetAxis("Horizontal") < 0)
        
        {

            sr.flipX = false;
            rb2.AddForce(new Vector2(-accel, 0));

            Anim.SetFloat("Velocity X", Mathf.Abs(rb2.velocity.x));

        }
    }
}

