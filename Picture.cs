using UnityEngine;
using System.Collections;

public class Picture : MonoBehaviour
{

    public Texture2D pictureTexture;
    public Texture2D scareTexture;
    public AudioClip scareSound;
    public float scareTime = 3f;

    bool showScare = false; //private bool showscare

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Renderer>().material.mainTexture = scareTexture;
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().clip = scareSound;
            GetComponent<AudioSource>().Play();

            showScare = true;
        }
    }

    void Update()
    {
        if (showScare)
        {
            scareTime -= Time.deltaTime;
            if (scareTime <= 0)
            {
                GetComponent<Renderer>().material.mainTexture = pictureTexture;
                GetComponent<AudioSource>().Stop();
                showScare = false;
            }
        }
    }
}
