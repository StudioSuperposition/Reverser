using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spashScript : MonoBehaviour
{
    void Awake()
    {
    }
    public void NextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2, UnityEngine.SceneManagement.LoadSceneMode.Single);

    }
}
