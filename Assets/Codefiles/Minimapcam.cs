using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimapcam : MonoBehaviour
{
    public Transform target = null;
    public bool followmove = true;
    public bool followrotation = true;
    public float offset = 7f;
    private Camera minimap = null;
    private bool fullscreen = false;
    private void Start()
    {
        minimap = GetComponent<Camera>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (fullscreen)
            {
                minimap.rect = new Rect(0.02f, 0.03f, 0.2f, 0.35f);

            }
            else
            {
                minimap.rect = new Rect(0, 0, 1, 1);
            }
            fullscreen = !fullscreen;
        }
    }
    
    
    /*minimap.rect = new Rect(0, 0, 1, 1);//or
            StartCoroutine(Fullscreen());
        }
    }
    IEnumerator Fullscreen()
    {
        yield return new WaitForSeconds(4);
        minimap.rect = new Rect(0.02f, 0.03f, 0.2f, 0.35f);
    }*/
    private void LateUpdate()
    {
        
        if(followmove)
        {
            transform.position = new Vector3(target.position.x,offset,target.position.z);
        }
        if (followrotation)
        {
           // transform.rotation = target.rotation;
            transform.rotation = Quaternion.Euler(90, target.eulerAngles.y, 0);
        }
    }

}
