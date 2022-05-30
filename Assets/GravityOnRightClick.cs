using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOnRightClick : MonoBehaviour
{
    // Start is called before the first frame update
    public float slow;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Time.timeScale = Mathf.Lerp(Time.timeScale,slow,speed*Time.deltaTime);
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
