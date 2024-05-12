using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public CameraControl cameraControl = null;
    public CameraControl.Choose cameraState = CameraControl.Choose.idle;
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube")
        {

            cameraControl.check(cameraState);

        }
    }
}
