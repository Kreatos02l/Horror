using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoctorTrigger : MonoBehaviour {

    public ZombieDoctorMove zz;
    public bool scare = true;
    public AudioSource laugh;
    public Canvas doccanvas;
    // Update is called once per frame
    private void Start()
    {
        doccanvas.enabled = false;
    }
    void Update () {
        if (Inventory.keys[5] == true && scare == true)
        {
            zz.zombie.SetActive(true);
            laugh.Play();
            doccanvas.enabled = true;
            scare = false;
        }
    }
}
