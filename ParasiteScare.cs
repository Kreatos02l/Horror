using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParasiteScare : MonoBehaviour {

    public AudioSource Scream;
    public GameObject ThePlayer;
    public GameObject JumpCam;
    public GameObject FlashImg;
    public bool scare = true;
    public EnemyChase ec;
    public EnemyChase ec1;
    public EnemyChase ec2;
    void OnTriggerEnter()
    {
        if (scare)
        {
            StartCoroutine(EndJump());
            ec.monster.SetActive(true);
            ec1.scaresound[0].Play();
            ec1.monster.SetActive(true);
            ec2.monster.SetActive(true);
        }
    }

    IEnumerator EndJump()
    {
        yield return new WaitForSeconds(0.5f);
        Scream.Play();
        JumpCam.SetActive(true);
        ThePlayer.SetActive(false);
        FlashImg.SetActive(true);
        yield return new WaitForSeconds(2.03f);
        ThePlayer.SetActive(true);
        JumpCam.SetActive(false);
        FlashImg.SetActive(false);
        scare = false;
    }
}
