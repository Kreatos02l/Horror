using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrig : MonoBehaviour {

    public bool endTrig = true;

    private void OnTriggerEnter(Collider other)
    {
        if(endTrig)
        {
            Application.LoadLevel("End");
            endTrig = false;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
