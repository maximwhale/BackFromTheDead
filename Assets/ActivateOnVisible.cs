using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnVisible : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    public SpriteRenderer rend;
    private void Update()
    {
        if (rend.isVisible)
        {
            target.SetActive(true);
        }
        else
        {
            target.SetActive(false);
        }
    }
}

