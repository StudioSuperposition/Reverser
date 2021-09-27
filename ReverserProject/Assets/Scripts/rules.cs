using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rules : MonoBehaviour
{
    public void nextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4, UnityEngine.SceneManagement.LoadSceneMode.Single);
    }
}
