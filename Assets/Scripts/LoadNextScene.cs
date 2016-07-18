using UnityEngine;
using System.Collections;

public class LoadNextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(gameObject);
        StartCoroutine(LoadingTheNextScene());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator LoadingTheNextScene()
    {
        Debug.Log("Begin loading the next scene");
        yield return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync("Tutorial");
        Debug.Log("End loading the next scene");
    }
}
