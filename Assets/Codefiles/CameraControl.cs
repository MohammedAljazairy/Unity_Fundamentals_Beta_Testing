using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Followcamera followcamera = null;
    private Lookat Lookatcamera = null;

    public enum Choose {idle,Lookat,Follow,both };
    public Choose state = Choose.idle;
    private void Start()
    {
        followcamera = GetComponent<Followcamera>();
        Lookatcamera = GetComponent<Lookat>();
        check(state);


    }
  
    public void check(Choose s)
    {
        switch(s)
        {
            case Choose.idle:  stateidle  (); break;
            case Choose.Lookat:statelookat(); break;
            case Choose.Follow:statefollow(); break;
            case Choose.both:    stateboth(); break;
        }


    }
    void stateidle  () 
    {
        followcamera.enabled = false;
        Lookatcamera.enabled = false;
    }
    void statelookat() 
    {
        Lookatcamera.enabled = true;
        followcamera.enabled = false;
    }
    void statefollow() 
    {

        followcamera.enabled=true;
        Lookatcamera.enabled = false;
    }
    void stateboth  () 
    {   followcamera.enabled = true;
        Lookatcamera.enabled = true;
    }
}
