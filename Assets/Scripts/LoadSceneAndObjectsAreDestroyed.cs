using UnityEngine;
using System.Collections;

public class LoadSceneAndObjectsAreDestroyed : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        StartCoroutine(LoadingTheNextScene());
    }

    IEnumerator LoadingTheNextScene()
    {
        Debug.Log("Begin loading the next scene");
        yield return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Tutorial");

        // This line is never called! Since the GameObject this script is attached to
        // is destroyed on loading the scene. If we want this line to be called,
        // then we need to use Object.DontDestroyOnLoad to protect the GameObject.
        //
        // See the script ProtectGameObjectOnLoad.
        Debug.Log("End loading the next scene");
    }
}
