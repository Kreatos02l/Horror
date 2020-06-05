using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PauseMenu : MonoBehaviour
{


    public static bool isPaused = false;

    public GameObject pauseMenuHolder;
    public PlayerMove player;
    public PlayerLook camera;
    public bool exitOpen = false;
    public Canvas exitInfo;
    public EnemyChase monster;
    public EnemyChase monster1;
    public EnemyChase monster2;
    void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
            
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        
    }

    public void PauseGame ()
    {
        pauseMenuHolder.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        player.movementSpeed = 0;
        camera.mouseSensitivity = 0;
        isPaused = true;
        monster.GetComponent<NavMeshAgent>().speed = 0;
        monster1.GetComponent<NavMeshAgent>().speed = 0;
        monster2.GetComponent<NavMeshAgent>().speed = 0;
    }

    public void ResumeGame()
    {
        pauseMenuHolder.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        player.movementSpeed = 50;
        camera.mouseSensitivity = 150;
        isPaused = false;
        monster.GetComponent<NavMeshAgent>().speed = 10;
        monster1.GetComponent<NavMeshAgent>().speed = 10;
        monster2.GetComponent<NavMeshAgent>().speed = 10;
    }

    public void LoadMenu()
    {
        Application.LoadLevel("mainmenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ExitCanvas()
    {
        if (exitOpen == false)
        {
            exitOpen = true;
            exitInfo.enabled = true;
            pauseMenuHolder.SetActive(false);
        }
        else
        {
            exitOpen = false;
            exitInfo.enabled = false;
            pauseMenuHolder.SetActive(true);
        }
    }

}
