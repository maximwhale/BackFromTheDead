using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeOnDestroy : MonoBehaviour
{
    public float duration;
    public float magnitude;
    // Start is called before the first frame update
    private void OnDestroy()
    {
        if (FindObjectOfType<Shaker>())
        {
            FindObjectOfType<Shaker>().Shake(duration, magnitude);
        }
    }
}
