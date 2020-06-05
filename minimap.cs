using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class minimap : MonoBehaviour {

    public Canvas map;
    public bool minimapOpen = false;
    public PlayerLook camera;
    public PlayerMove player;
    public EnemyChase monster;
    public EnemyChase monster1;
    public EnemyChase monster2;
    // Use this for initialization
    void Start () {
        minimapOpen = false;
        map.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.M))
        {
            if (minimapOpen == false)
            {
                minimapOpen = true;
                GetComponent<AudioSource>().Play();
                player.movementSpeed = 0;
                camera.mouseSensitivity = 0;
                map.enabled = true;
                monster.GetComponent<NavMeshAgent>().speed = 0;
                monster1.GetComponent<NavMeshAgent>().speed = 0;
                monster2.GetComponent<NavMeshAgent>().speed = 0;
            }
            else
            {
                minimapOpen = false;
                GetComponent<AudioSource>().Play();
                player.movementSpeed = 50;
                camera.mouseSensitivity = 150;
                map.enabled = false;
                monster.GetComponent<NavMeshAgent>().speed = 10;
                monster1.GetComponent<NavMeshAgent>().speed = 10;
                monster2.GetComponent<NavMeshAgent>().speed = 10;
            }
        }
	}
}
