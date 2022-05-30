using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            GameObject.FindGameObjectWithTag("Boss").SetActive(false);
            SceneManager.LoadScene(0);
        }
    }
}
