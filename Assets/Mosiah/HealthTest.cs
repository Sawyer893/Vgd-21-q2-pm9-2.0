using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthTest : MonoBehaviour
{
    public HealthBar healthbar1;
    public float health = 1f;


    private void Update()
    {

        if (health > 0)
        {

            StartCoroutine(healthbar());
            health -= 0.1f;
            healthbar1.SetSize(health);

        }
    }
    IEnumerator healthbar()
    {

        yield return new WaitForSeconds(0.03f);

    }
}