using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTarget : MonoBehaviour
{
    public FlipToTarget fl;
    public TurnTowardsTarget tr;
    public Shoot sh;
    // Start is called before the first frame update
    private void Awake()
    {
        Transform target = GameObject.FindGameObjectWithTag("Player").transform;
        fl.target = target;
        tr.target = target;
        sh.target = target;

    }

    // Update is called once per fra
}
