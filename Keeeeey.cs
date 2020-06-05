using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keeeeey : MonoBehaviour {

    public bool keyGui;
    public bool closeDoor;
    public float interactDistance = 5f;
    public GUIStyle mygui;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDistance))
            {
                if (hit.collider.CompareTag("Door"))
                {
                    Doooooor doorScript = hit.collider.transform.parent.GetComponent<Doooooor>();
                    if (doorScript == null) return;

                    if (Inventory.keys[doorScript.index] == true)
                    {
                        doorScript.ChangeDoorState();
                    }
                }
                else if (hit.collider.CompareTag("Key"))
                {
                   
                    Inventory.keys[hit.collider.GetComponent<AdamGibiKey>().index] = true;
                    Destroy(hit.collider.gameObject);
                    keyGui = true;
                }

            }
        }

    }

    void OnGUI()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            if (hit.collider.CompareTag("Key"))
            {
                GUI.color = Color.red;
                GUI.Box(new Rect(0, 0, 200, 25), "Press E to take the key",mygui);
            }

            else if(hit.collider.CompareTag("Door"))
            {
                if (!keyGui)
                {
                    GUI.color = Color.red;
                    GUI.Box(new Rect(0, 0, 200, 25), "Need a key!",mygui);
                }
                if (keyGui == true && closeDoor == false)
                {
                    GUI.color = Color.red;
                    GUI.Box(new Rect(0, 0, 300, 25), "Press E to open and close the door.",mygui);
                }
                if (closeDoor)
                {
                    GUI.color = Color.red;
                    GUI.Box(new Rect(0, 0, 300, 25), "Press E to open and close the door.",mygui);
                }
            }
        }
    }
}
