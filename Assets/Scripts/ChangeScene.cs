using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    GameObject sceneToLoad;
    public Scene toLoad;

    public void LoadNewScene()
    {
        SceneManager.LoadScene(toLoad.handle);
    }
}
