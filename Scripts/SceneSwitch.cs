using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        Scene scene = SceneManager.GetActiveScene();
        
        if(scene.name == "Scene2")
        {
            SceneManager.LoadScene(0); // Loads scene 1
        }
        else 
        {
            SceneManager.LoadScene(1); // Loads scene 2
        }
        
    }
}
