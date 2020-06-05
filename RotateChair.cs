using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChair : MonoBehaviour {

    public Animator anim;
    public AudioSource audio;
    public bool sound = true;
    private void Start()
    {
        anim.enabled = false;
        audio.enabled = false;
    }

    
    void Update () {
        
        if (Inventory.keys[2] == true && sound == false)
        {
            transform.position = new Vector3(275.7f, 77.3f, 147.4f);
            anim.enabled = true;
            audio.enabled = true;
        }
    }
}
