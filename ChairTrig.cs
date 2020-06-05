using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairTrig : MonoBehaviour {

    public bool chairTrig;
    public RotateChair rc;
    private void Start()
    {
        chairTrig = true;
    }
    public void OnTriggerEnter(Collider other)
    {
        rc.sound = true;
        rc.anim.enabled = false;
        rc.audio.enabled = false;
        if (chairTrig)
        {
            rc.sound = false;
            chairTrig = false;
        }
    }
}
