using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeOnAwake : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    public float magnitude;
    void Awake()
    {
        FindObjectOfType<Shaker>().Shake(time, magnitude);
    }


}
