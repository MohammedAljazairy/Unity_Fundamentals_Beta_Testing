using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggercheck : MonoBehaviour
{
    public int hitpoint = 4;
    private void OnTriggerEnter(Collider other)
    {
        if(other.name=="Sphere")
        {    hitpoint--;
            if (hitpoint <= 0)
            {
                Destroy(this.gameObject);

            }
        
        }
    }
}
