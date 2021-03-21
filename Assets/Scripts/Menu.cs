using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void NewGameButton(string newGame)
    {
        SceneManager.LoadScene(newGame);
    }

    public void ExitGameBtn()
    {
        Application.Quit();
    }
}
