using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class speed : MonoBehaviour
{
    public float speedo;
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(CalcSpeed());
    }
    IEnumerator CalcSpeed()
    {
        bool isPlaying = true;
        while (isPlaying)
        {
            Vector3 prevPos = transform.position;
            yield return new WaitForFixedUpdate();
            speedo = Mathf.Round(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime);
        }
    }
}

