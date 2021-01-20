using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static float Ghealth;
    public HealthBar healthbar1;
    private void Start()
    {
        Ghealth = 1.0f;
    }
    private void Update()
    {
        GameManager.Ghealth -= 0.0004f;
        healthbar1.SetSize(GameManager.Ghealth);
    }
}
