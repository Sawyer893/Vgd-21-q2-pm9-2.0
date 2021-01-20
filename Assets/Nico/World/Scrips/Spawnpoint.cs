using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnpoint : MonoBehaviour
    
{
    private Vector3 playerKnock;
    public GameObject mainPlayer;

    // Start is called before the first frame update
    void Start()
    {
        playerKnock = mainPlayer.transform.position;
        transform.localPosition = playerKnock;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
