using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnDestroy : MonoBehaviour
{
    public string[] names;
    // Start is called before the first frame update
    private void OnDestroy()
    {
        if (FindObjectOfType<AudioManager>())
        {
            FindObjectOfType<AudioManager>().Play(names[Random.Range(0, names.Length)]);
        }
    }

}

