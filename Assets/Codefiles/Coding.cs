using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coding : MonoBehaviour
{

    public float speed = 5.0f;
    public float rotatespeed1 = 125f;
    public Color colorchange = Color.blue;
    public GameObject prefabhit = null;
    public GameObject prefabsphere = null;
    public Transform socket = null;
    public float forceamount = 400;
    public AudioSource Hitsound = null;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            GameObject obj= Instantiate(prefabsphere, socket.position, socket.rotation);
            obj.name = "Sphere";
            float rnd = Random.Range(0.35f, 1.0f);
            obj.transform.localScale=Vector3.one * rnd;
            obj.GetComponent<Rigidbody>().AddForce(socket.forward* forceamount, ForceMode.Acceleration);

        }
        if (Input.GetKey(KeyCode.W))
            transform.Translate(0,0,speed*Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            transform.Translate(0, 0, -speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.E))
            transform.Translate(speed * Time.deltaTime, 0,0);
        else if (Input.GetKey(KeyCode.Q))
            transform.Translate(-speed * Time.deltaTime, 0,0);
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, rotatespeed1 * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, -rotatespeed1 * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.Z))
            transform.localScale = Vector3.one * 0.5f;

        //        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        if (Input.GetKeyDown(KeyCode.X))
            transform.localScale = Vector3.one;
        if (Input.GetKeyDown(KeyCode.C))
            GetComponent<Renderer>().material.color = colorchange;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Wall hit")
        {
            Hitsound.Play();
            Instantiate(prefabhit, this.transform.position, Quaternion.identity);
        }
       
    }
}
