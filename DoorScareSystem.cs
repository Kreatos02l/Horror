using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class DoorScareSystem : MonoBehaviour
{

    public GameObject ScareObject;
    public string ScareObjectAnim;
    public string JumscareAnim;
    public AudioClip ScareSound;

    void Start()
    {
        ScareObject.GetComponent<Animation>().Stop(ScareObjectAnim);             //stop looping (walk, run or any) animation on scare object
    }

    public void OnTriggerEnter(Collider other)
    {
            ScareObject.GetComponent<Animation>().Play(ScareObjectAnim);            //play stopped scare object animation
            GetComponent<Animation>().Play(JumscareAnim);       //play jumpscare animation
            GetComponent<AudioSource>().clip = ScareSound;                    //set scare sound
            GetComponent<AudioSource>().Play();                                           //play scare sound
            GetComponent<Collider>().enabled = false;                      //disable collider for repeat scare
       //enable sanity
            StartCoroutine(ScaredWait());            //wait for destroy and sanity
    }

    IEnumerator ScaredWait()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(this);
    }
}
