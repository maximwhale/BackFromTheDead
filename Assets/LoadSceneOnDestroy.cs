using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public int sceneIndex;
    private void OnDestroy()
    {
        if (gameObject.activeSelf)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        
    }
}
