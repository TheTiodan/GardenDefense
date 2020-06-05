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
            StartCoroutine(WaitForTime());
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator WaitForTime()
    {
       yield return new WaitForSeconds(SceneLoadDelay);
       LoadNextScene();
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
    public void ReloadScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void LoadStartScreen()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartScreen");

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene("OptionsScreen");
    }
}
