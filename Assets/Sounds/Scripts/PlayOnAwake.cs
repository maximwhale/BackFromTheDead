using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayOnAwake : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Awake()
    {
        FindObjectOfType<AudioManager>().Play(name);
    }

}
