using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagSceneChange : MonoBehaviour
{
    public string levelToLoad;

    private void OnTriggerEnter(Collider otherCollider)
    {
        //Debug.Log("Object hit the flag");

        if (otherCollider.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }

        
    }
}
