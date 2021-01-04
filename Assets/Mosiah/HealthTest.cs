using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthTest : MonoBehaviour
{
    public HealthBar healthbar1;
    public float health = 1f;
   

    private void Update()
    {

        if (health > .001f)
        {

            StartCoroutine(healthbar());
            health -= 0.0005f;
            healthbar1.SetSize(health);

        }else
        {
            Debug.Log("Switch scene");
            SceneManager.LoadScene("DeadHealth");
        }
    }
    IEnumerator healthbar()
    {

        yield return new WaitForSeconds(0.03f);

    }
}