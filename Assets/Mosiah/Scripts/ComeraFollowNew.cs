using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeraFollowNew : MonoBehaviour
{
    public Transform targetTransform;
    Vector3 tempVec3 = new Vector3();

    void Update()
    {
        tempVec3.x = targetTransform.position.x;
        if (this.transform.position.y < -4)
        {
            tempVec3.y = this.transform.position.y;
        }
        else
        {
            tempVec3.y = targetTransform.position.y;
        }


        //tempVec3.x = targetTransform.position.x;
        //tempVec3.y = targetTransform.position.y;
        //tempVec3.y = this.transform.position.y;
        tempVec3.z = this.transform.position.z;
        this.transform.position = tempVec3;
    }
}
