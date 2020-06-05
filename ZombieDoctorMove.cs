using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDoctorMove : MonoBehaviour {

    public Transform Player;
    public float MoveSpeed = 4;
    public float MinDist = 5;
    public float MaxDist = 10;
    public GameObject zombie;
    public KeyDoctorTrigger kdt;
    private void Start()
    {
        zombie.SetActive(false);
    }
    void Update () {
        if (Inventory.keys[5] == true)
        {
            transform.LookAt(Player);
            if (Vector3.Distance(transform.position, Player.position) >= MinDist)
            {
                
                transform.position += transform.forward * MoveSpeed * Time.deltaTime;
                if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
                {
                    zombie.SetActive(false);
                    kdt.doccanvas.enabled = false;
                }
            }
        }
	}

}
