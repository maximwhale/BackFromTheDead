using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    // Start is called before the first frame update
    public string name;
    public void Play()
    {
        GameObject.FindObjectOfType<AudioManager>().Play(name);
    }
}
