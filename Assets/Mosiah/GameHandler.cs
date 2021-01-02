using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    [SerializeField] public HealthBar healthBar;

    private void Start()
    {
        float health = 1f;

        if (health > 0.1f)
        {
            health -= .01f;
            healthBar.SetSize(health);

            if(health < .3f)
            {
                if((health * 100f) % 3 == 0)
                {
                    healthBar.SetColor(Color.white);
                } else
                {
                    healthBar.SetColor(Color.red);
                }
            }
        }
    }
    }
