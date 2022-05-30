using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    // Start is called before the first frame update
    public void Shake(float duration, float magnitude)
    {
        StartCoroutine(Shaking(duration, magnitude));
    }

    // Update is called once per frame
    IEnumerator Shaking(float duration, float magnitude)
    {
        Vector3 orginialPos = transform.position;
        
        while (duration > 0)
        {
            duration -= Time.deltaTime;

            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = orginialPos + new Vector3(x, y);
            yield return null;
        }
        transform.position = orginialPos;
    }
}
