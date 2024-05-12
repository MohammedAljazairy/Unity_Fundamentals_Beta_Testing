using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lookat : MonoBehaviour
{ public GameObject target = null;
    public float speed = 5.0f;
    void Update()
    {
        //transform.LookAt(target.transform);
        var targetrotation = Quaternion.LookRotation(target.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation,targetrotation,speed*Time.deltaTime);
    }
}
