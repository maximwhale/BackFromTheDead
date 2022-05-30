using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Mouse_position();
    }
    private Vector3 Mouse_position()
    {
        Vector3 mp = Input.mousePosition;
        mp = cam.ScreenToWorldPoint(mp);
        mp.z = 0;

        return mp;
    }
}
