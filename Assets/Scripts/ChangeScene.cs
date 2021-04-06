using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    GameObject sceneToLoad;
    public Scene toLoad;

    private void Update()
    {
     
        if (Input.GetKeyDown("Escape") || Input.GetKeyDown("e"))
        {
            LoadNewScene();
        }
    }

    public void LoadNewScene()
    {
        SceneManager.LoadScene(toLoad.handle);
    }
}
