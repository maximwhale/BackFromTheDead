using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipToTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        if (target)
        {
            transform.localScale = new Vector3(
                Mathf.Abs(transform.localScale.x) * Mathf.Sign(target.position.x - transform.position.x),
                transform.localScale.y);
        }
    }
}
