using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthTest : MonoBehaviour
{
    //public HealthBar healthbar1;
    //public float GameManager.Ghealth = 1f;
    public GameObject player;

    private void Update()
    {

        if (GameManager.Ghealth > .001f)
        {

            //StartCoroutine(healthbar());
            //GameManager.Ghealth -= 0.0005f;
            //healthbar1.SetSize(GameManager.Ghealth);

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
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(GameManager.Ghealth);
        GameManager.Ghealth += 0.03f;
        //healthbar1.SetSize(GameManager.Ghealth);
        //Debug.Log(GameManager.Ghealth);
        Destroy(gameObject);
    }
}