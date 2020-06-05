using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doooooor : MonoBehaviour {

    public int index = -1;
    public bool open = false;
    public float doorOpenAngle = 90f; //Angle where the door is opened
    public float doorCloseAngle = 0f; //Start angle
    public Keeeeey ky;
    public void ChangeDoorState()
    {
       
        open = !open;
        GetComponent<AudioSource>().Play();
    }

    public void Update()
    {
            if (open) //open == true
            {
                Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
                transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, targetRotation, 0.8f * Time.deltaTime);
                ky.closeDoor = true;
            }
            else
            {
                Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0);
                transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, targetRotation2, 0.5f * Time.deltaTime);
                ky.closeDoor = false;
            }
    }
}
