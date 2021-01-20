using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour
{
	public Rigidbody2D rb2;
	public bool knockBack;
	public float thrust;
	// Use this for initialization
	void Start()
	{
		rb2 = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (knockBack)
		{
			knockBack = !knockBack;
			//if intfont of player make - thrust if behind player make thrust
			rb2.AddForce(transform.right * -thrust);
			rb2.AddForce(transform.up * thrust);
		}

	}
}
