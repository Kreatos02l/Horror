using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningCrawl : MonoBehaviour
{

    public GameObject jumpscareObject;

    void Start()
    {

        jumpscareObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            jumpscareObject.SetActive(true);
            StartCoroutine(DestroyObject());
        }
    }
    IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(jumpscareObject);
        Destroy(gameObject);
    }
}