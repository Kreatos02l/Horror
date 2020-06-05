using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyChase : MonoBehaviour {

    private NavMeshAgent myAgent;
    public Transform target;
    public AudioSource[] scaresound;
    public Count cc;
    public GameObject monster;
    // Use this for initialization
    void Start () {
        myAgent = GetComponent<NavMeshAgent>();
        monster.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
        myAgent.SetDestination(target.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        scaresound[1].Play();
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
        cc.count = cc.count + 1;
        if (cc.count == 3)
        {
            yield return new WaitForSeconds(3f);
            cc.gameOver.enabled = false;
            Application.LoadLevel("mainmenu");
        }
        Destroy(this.gameObject);    
        
    }
}

