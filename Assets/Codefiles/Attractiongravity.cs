using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractiongravity : MonoBehaviour
{
    public float gravity = 10.0f;
    public void Attractor(Rigidbody rigidbody) {
        Vector3 up = (rigidbody.position - transform.position).normalized;
        Vector3 localUp = rigidbody.transform.up;
        rigidbody.AddForce(up * gravity);
        rigidbody.rotation = Quaternion.FromToRotation(localUp,up)*rigidbody.rotation;
    }
}
