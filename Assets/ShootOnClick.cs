using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootOnClick : MonoBehaviour
{
    public Shoot shootScript;
    // Start is called before the first frame update

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            shootScript.Fire();
        }
    }
}
