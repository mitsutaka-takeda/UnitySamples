using UnityEngine;
using System.Collections;

public class ProtectGmaeObjectOnLoad : MonoBehaviour {
    // Use this for initialization
    void Start()
    {
        // Tell the system that don't destroy this GameObject on loading the next scene.
        DontDestroyOnLoad(gameObject);
        StartCoroutine(LoadingTheNextScene());
    }

    IEnumerator LoadingTheNextScene()
    {
        Debug.Log("Begin loading the next scene");
        yield return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Tutorial");
        Debug.Log("End loading the next scene");
    }
}
