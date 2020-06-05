using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour {
    public int count;
    public Canvas gameOver;

    private void Start()
    {
        gameOver.enabled = false;
    }
    // Update is called once per frame
    void Update () {
        if (count == 3)
            gameOver.enabled = true;
	}
}
