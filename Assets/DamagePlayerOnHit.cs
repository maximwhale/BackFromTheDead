using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayerOnHit : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<PlayerVersionManager>().Damage();
            FindObjectOfType<Shaker>().Shake(0.4f, 0.1f);
            Destroy(gameObject);
        }
    }

}
