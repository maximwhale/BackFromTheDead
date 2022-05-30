using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public Transform target;
    public float speed;

    public float knockBackPower;

    public GameObject parent;
    public void Fire()
    {
        GameObject newBullet = Instantiate(bullet, transform);
        newBullet.transform.parent = null;
        newBullet.GetComponent<Rigidbody2D>().velocity = (target.position - transform.position).normalized * speed;
        KnockBack();
    }


    private void KnockBack()
    {
        parent.GetComponent<Rigidbody2D>().AddForce((transform.position - target.position).normalized * knockBackPower);
    }

}
