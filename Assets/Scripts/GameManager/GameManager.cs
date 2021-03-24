using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public delegate void GameMangerEventHandler();
    public event GameMangerEventHandler MenuToggleEvent;
    public event GameMangerEventHandler InventoryUIToggleEvent;
    public event GameMangerEventHandler RestartLevelEvent;
    public event GameMangerEventHandler GoToMenuSceneEvent;
    public event GameMangerEventHandler GameOverEvent;

    public bool isGameOver;
    public bool isInventoryUIOn;
    public bool isMenuOn;

    public void CallEventMenuToggle()
    {
        if (MenuToggleEvent != null)
        {
            MenuToggleEvent();
        }
    }

    public void CallEventInventoryUIToggle()
    {
        if (InventoryUIToggleEvent != null)
        {
            InventoryUIToggleEvent();
        }
    }

        public void CallEventRestartLevel()
        {
            if (RestartLevelEvent != null)
            {
                RestartLevelEvent();
            }
        }

        public void CallEventGotToMenuScene()
        {
            if (GoToMenuSceneEvent != null)
            {
                GoToMenuSceneEvent();
            }
        }

        public void CallEventGameOver()
        {
            if (GameOverEvent != null)
            {
                isGameOver = true;
                GameOverEvent();
            }
        }
}
