using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float SceneLoadDelay = 3f;
    int currentSceneIndex;
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadNextScene());
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator LoadNextScene()
    {
       yield return new WaitForSeconds(SceneLoadDelay);
       SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
