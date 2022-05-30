using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTowardsTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float adjust_angle = 30;

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            Vector3 diff = target.position - transform.position;
            if (Mathf.Abs(diff.x) > 0.05)
            {
                transform.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, Angle());
            }
        }

    }
    private float Angle()
    {
        Vector3 diff = target.position - transform.position;
        float angle = Mathf.Atan(Mathf.Abs(diff.y / diff.x));
        angle *= 180 / Mathf.PI;
        if (diff.y < 0)
        {
            angle = -angle;
        }
        if (diff.x < 0)
        {
            angle = -angle + adjust_angle;
        }
        else
        {
            angle -= adjust_angle;
        }
        return angle;
    }
}
