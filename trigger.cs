using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

    public GameObject scare;
    public bool played = false;
    public bool trig;

    public AudioClip scareSound;
////////Make sure its not visable and reset////////
    void Start()
    {
        trig = true;
        scare.GetComponent< Renderer > ().enabled = false;
    }
    /////When player enters trigger/////// set to true///////
    public void OnTriggerEnter( Collider other)
    {
        if(trig == true)
        {
            scare.GetComponent<Renderer>().enabled = true;
            StartCoroutine(Removeovertime());
            Makehimscream();
        }
    }
    //////Enable renderer and trigger sound and timer/////

    //// timer ////
    
    IEnumerator Removeovertime()
    {
        yield return new WaitForSeconds(0.5f);
        scare.GetComponent< Renderer > ().enabled = false;
        trig = false;
    }
    //// sound /////
    public void Makehimscream()
    {
        if (!played)
        {
            played = true;
            GetComponent< AudioSource > ().PlayOneShot(scareSound);
        }
    }


}
