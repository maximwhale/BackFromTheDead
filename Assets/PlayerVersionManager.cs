using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVersionManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<PlayerVersion> playerVersions;
    private int currentpvIndex=0;

    private PlayerVersion currenetPv;
    void Awake()
    {
        ActivatePlayerVersion(currentpvIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActivatePlayerVersion(int pv)
    {
        currentpvIndex = pv;
        currenetPv = playerVersions[pv];
        foreach (Transform child in transform.GetChild(0))
        {
            child.gameObject.SetActive(false);
        }
        FindObjectOfType<AudioManager>().Play("Die");
        currenetPv.Sprite.SetActive(true);
        transform.parent.position = currenetPv.position.position;
    }
    public void Damage()
    {
        Debug.Log("damages");
        ActivatePlayerVersion(currentpvIndex + 1);
    }
}
