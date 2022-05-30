using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOnTime : MonoBehaviour
{
    // Start is called before the first frame update
    public float time;
    public Shoot shootScript;

    private void OnEnable()
    {
        StartCoroutine(Shoot());
    }
    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(time);
        shootScript.Fire();
        StartCoroutine(Shoot());
        
    }
}
