using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeWorld : MonoBehaviour
{
    public string TaregtScene;
    public void NewScene()
    {
        SceneManager.LoadScene(TargetScene, LoadSceneMode.Single);
    }
}
