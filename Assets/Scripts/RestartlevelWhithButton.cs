using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartlevelWhithButton : MonoBehaviour
{
    [SerializeField]
    KeyCode keyRestart;
    
    void Update()
    {
        if (Input.GetKey(keyRestart))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
