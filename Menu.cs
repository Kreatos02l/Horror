using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	public Canvas exitInfo;
    public Canvas settingsInfo;
    public Canvas controlsInfo;
	public bool exitOpen=false;
    public bool settingsOpen = false;
    public bool controlsOpen = false;

    private void Start()
    {
        controlsInfo.enabled = false;
    }
    public void StartGame ()
	{
		Application.LoadLevel ("game");
	}
	public void ExitGame()
	{
		Application.Quit();
	}
	public void ExitCanvas()
	{
		if (exitOpen == false) {
			exitOpen = true;
			exitInfo.enabled = true;
            settingsOpen = false;
            settingsInfo.enabled = false;
        }
		else 
		{
			exitOpen = false;
			exitInfo.enabled = false;
		}
	}

    public void SettingsCanvas()
    {
        if (settingsOpen == false)
        {
            settingsOpen = true;
            settingsInfo.enabled = true;
            exitOpen = false;
            exitInfo.enabled = false;
        }
        else
        {
            settingsOpen = false;
            settingsInfo.enabled = false;
        }
    }

    public void ControlsCanvas()
    {
        if(controlsOpen == true)
        {
            controlsOpen = false;
            controlsInfo.enabled = false;
        }
        else
        {
            controlsOpen = true;
            controlsInfo.enabled = true;
        }
    }
}
