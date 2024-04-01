using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EndScene : MonoBehaviour
{
    public void quit()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex - 2) % SceneManager.sceneCountInBuildSettings;  //  says which scene to go to
        SceneManager.LoadScene(nextSceneIndex);  //  loads the start scene
    }
    public void retry()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex - 1) % SceneManager.sceneCountInBuildSettings;  //  says which scene to go to
        SceneManager.LoadScene(nextSceneIndex);  //  loads the start scene
    }
}
