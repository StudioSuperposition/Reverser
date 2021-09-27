using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playNextScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void nextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(3, UnityEngine.SceneManagement.LoadSceneMode.Single);

    }
}
