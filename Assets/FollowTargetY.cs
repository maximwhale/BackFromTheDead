using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTargetY : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.position = new Vector3(0, target.position.y, transform.position.z);
        }
        
    }
}
