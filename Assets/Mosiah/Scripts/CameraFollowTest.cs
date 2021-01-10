using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTest : MonoBehaviour
{
    // Start is called before the first frame update
    //define player game object
    public GameObject player;

    //wait for lateupdate
    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y > 0 player.transform.position = 0, -10f);
    }
}
