using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour {

    CharacterController cc;
    public AudioSource[] AudioClips;
    public bool isCooldown;
    // Use this for initialization
    void Start () {
        cc = GetComponent<CharacterController>();
        AudioClips[2].Play();
	}
	
	// Update is called once per frame
	void Update ()
    {
       
		if(cc.isGrounded == true && cc.velocity.magnitude > 2f && AudioClips[0].isPlaying == false)
        {
            AudioClips[0].Play();
            isCooldown = true;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && AudioClips[1].isPlaying == false)
        {
            if (isCooldown)
            {
                AudioClips[1].Play();
                isCooldown = false;
            }
        }

	}

}
