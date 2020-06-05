using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour
{

    public static bool doorKey;
    public bool open;
    public bool close;
    public bool inTrigger;
    public GameObject doortag;
    public CharacterKey charkey;
    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }

    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void Update()
    {
        if (inTrigger)
        {
            if (close)
            {
                if (doorKey)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        if (charkey.Key1 == true)
                        {
                            if (doortag.tag == "Door-1")
                            {
                                open = true;
                                close = false;
                                GetComponent<AudioSource>().Play();
                            }
                        }

                        if (charkey.Key2 == true)
                        {
                            if (doortag.tag == "Door-2")
                            {
                                open = true;
                                close = false;
                                GetComponent<AudioSource>().Play();
                            }
                        }

                        if (charkey.Key3 == true)
                        {
                            if (doortag.tag == "Door-3")
                            {
                                open = true;
                                close = false;
                                GetComponent<AudioSource>().Play();
                            }
                        }
                        if (charkey.Key4 == true)
                        {
                            if (doortag.tag == "Door-4")
                            {
                                open = true;
                                close = false;
                                GetComponent<AudioSource>().Play();
                            }
                        }

                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    close = true;
                    open = false;
                }
            }
        }

        if (open)
        {

            if (doortag.tag == "Door-1")
            {
                var newsa = Quaternion.Euler(0.0f, -90.0f, 0.0f);
                // var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
                transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, newsa, Time.deltaTime * 0.8f);
            }
            if (doortag.tag == "Door-2")
            {
                var newsa = Quaternion.Euler(0.0f, 90.0f, 0.0f);
                // var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
                transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, newsa, Time.deltaTime * 0.8f);
            }
            if (doortag.tag == "Door-3")
            {
                var newsa = Quaternion.Euler(0.0f, 90.0f, 0.0f);
                // var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
                transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, newsa, Time.deltaTime * 0.8f);
            }
            if (doortag.tag == "Door-4")
            {
                var newsa = Quaternion.Euler(0.0f, 90.0f, 0.0f);
                // var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 200);
                transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, newsa, Time.deltaTime * 0.8f);
            }
        }
        else
        {
            if (doortag.tag == "Door-1" && charkey.Key1 == true)
            {
                var newRot = Quaternion.Euler(0.0f, 180.0f, 0.0f);
                transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, newRot, Time.deltaTime * 0.8f);
            }
            if (doortag.tag == "Door-2" && charkey.Key2 == true)
            {
                var newRot = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, newRot, Time.deltaTime * 0.8f);
            }
            if (doortag.tag == "Door-3" && charkey.Key3 == true)
            {
                var newRot = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, newRot, Time.deltaTime * 0.8f);
            }
            if (doortag.tag == "Door-4" && charkey.Key4 == true)
            {
                var newRot = Quaternion.Euler(0.0f, 0.0f, 0.0f);
                transform.GetChild(0).rotation = Quaternion.Slerp(transform.GetChild(0).rotation, newRot, Time.deltaTime * 0.8f);
            }
        }
    }

    void OnGUI()
    {
        if (inTrigger)
        {
            if (open)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press E to close");
            }
            else
            {
                if (doorKey)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Press E to open");
                }
                else
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Need a key!");
                }
            }
        }
    }
}