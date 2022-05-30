using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyIfOnTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public string tagName;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag(tagName))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(tagName))
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(tagName))
        {
            Destroy(gameObject);
        }
    }
}
