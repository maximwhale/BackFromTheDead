using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMinChildren : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public int min;
    void Update()
    {
        if (transform.childCount < min)
        {
            Destroy(gameObject);
        }
    }
}
