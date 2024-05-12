using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followcamera : MonoBehaviour
{
    public Transform target = null;
    public float SmoothTime = 0.05f;
    public Vector3 offset = new Vector3(0.5f,-3,6);
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,target.position-offset,SmoothTime);
    }
}
