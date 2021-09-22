using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class masterScript : MonoBehaviour
{
    
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
