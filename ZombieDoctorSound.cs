using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDoctorSound : MonoBehaviour {

    public AudioSource scaresound;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            scaresound.GetComponent<AudioSource>().Play();
        }
    }

}
