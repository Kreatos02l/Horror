using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Opening : MonoBehaviour {

    public GameObject player;
    public GameObject FadeScreen;
    public GameObject TextBox;

	void Start () {
        player.GetComponent<PlayerMove>().enabled = false;
        StartCoroutine(ScenePlayer());
	}
	
    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);
        FadeScreen.SetActive(false);
        TextBox.GetComponent<Text>().text = "I need to get out of here.";
        yield return new WaitForSeconds(2);
        TextBox.GetComponent<Text>().text = "";
        player.GetComponent<PlayerMove>().enabled = true;
    }
	
}
