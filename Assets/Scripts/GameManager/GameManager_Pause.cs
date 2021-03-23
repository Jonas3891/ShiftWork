using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager_Pause : MonoBehaviour
{

    private GameManager gameManagerMaster;
    private bool isPaused;

    private void OnEnable()
    {
        SetInitialReference();
        gameManagerMaster.menuToggleEvent += TogglePause;
    }

    private void OnDisable()
    {
        gameManagerMaster.menuToggleEvent -= TogglePause;
    }

    void SetInitialReference()
    {
        gameManagerMaster = GetComponent<GameManager>();
    }

    void TogglePause()
    {
        if(isPaused){
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
}
