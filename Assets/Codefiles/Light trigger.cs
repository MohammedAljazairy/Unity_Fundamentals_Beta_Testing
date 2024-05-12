using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighttrigger : MonoBehaviour
{
    public GameObject lightobj = null;
    public GameObject particleobj = null;
    public GameObject doorobj = null;
    public AudioSource dooropensound = null;
    public int sound_check =0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Cube") {
            lightobj.SetActive(true);
            if(sound_check==0){
            sound_check++;
            GetComponent<AudioSource>().Play();
            StartCoroutine(playParticle());
        }
        }
        
    }
    IEnumerator playParticle()
    {
        yield return new WaitForSeconds(2);
        dooropensound.Play();
        particleobj.SetActive(true);
        LeanTween.move(doorobj, doorobj.transform.position - new Vector3(0,5,0), 10);
    }
    private void OnTriggerExit(Collider other)
    {
        {
            if (other.name == "Cube")
            {
                lightobj.SetActive(false);

            }
        }
    }

}
