using UnityEngine;
using System.Collections;

public class DoorKey : MonoBehaviour
{

    public bool inTrigger;
    public CharacterKey ck;
    public GameObject key;
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (key.tag == "Key-1")
                {
                    ck.Key1 = true;
                }
                if (key.tag == "Key-2")
                {
                    ck.Key1 = false;
                    ck.Key2 = true;
                }
                if (key.tag == "Key-3")
                {
                    ck.Key1 = false;
                    ck.Key2 = false;
                    ck.Key3 = true;
                }
                if (key.tag == "Key-4")
                {
                    ck.Key1 = false;
                    ck.Key2 = false;
                    ck.Key3 = false;
                    ck.Key4 = true;
                }
               
                DoorScript.doorKey = true;
                this.gameObject.SetActive(false);
            }
        }
    }

    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "Press E to take key");
        }
    }
}
