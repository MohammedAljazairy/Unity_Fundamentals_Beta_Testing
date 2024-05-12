using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodygravity : MonoBehaviour
{
    public Attractiongravity attractiongravity = null;
    private Rigidbody rb = null;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;//to colse the engine gravity
        rb.constraints = RigidbodyConstraints.FreezePosition;
    }
    private void FixedUpdate()
    {
        attractiongravity.Attractor(rb);
    }
}
