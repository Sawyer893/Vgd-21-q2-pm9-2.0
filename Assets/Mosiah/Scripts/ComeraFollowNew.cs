using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeraFollowNew : MonoBehaviour
{
    public Transform targetTransform;
    Vector3 tempVec3 = new Vector3();
    public float ymin, ymax;
    public float xmin, xmax;

    void Update()
    {
        
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(targetTransform.position.y, ymin, ymax);
        transform.position = pos;
        if (targetTransform.position.y < -4)
        {
            tempVec3.y = this.transform.position.y;
        }
        else
        {
            tempVec3.y = pos.y;
        }
          tempVec3.x = targetTransform.position.x;
        tempVec3.y = pos.y;
        tempVec3.z = this.transform.position.z;
        this.transform.position = tempVec3;
    }
}
