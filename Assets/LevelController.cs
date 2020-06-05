using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winLabel;
    [SerializeField] GameObject loseLabel;
    [SerializeField] float nextLevelDelay = 3f;
    int numberOfAttackers = 0;
    bool levelTimerFinished = false;


    private void Start()
    {
        winLabel.SetActive(false);
        loseLabel.SetActive(false);
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }
    public void AttackerKilled()
    {
        numberOfAttackers--;
        if (numberOfAttackers <=0 && levelTimerFinished)
        {
            Debug.Log("Level Complete");
            StartCoroutine(HandleWinCondition());
        }
    }
    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        if (numberOfAttackers <= 0)
        {
            Debug.Log("Level Complete");
            StartCoroutine(HandleWinCondition());
        }
    }
    private IEnumerator HandleWinCondition()
    {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(nextLevelDelay);
        FindObjectOfType<LevelLoader>().LoadNextScene();
    }
    public void HandleLoss()
    {
        loseLabel.SetActive(true);
        Time.timeScale = 0;
    }

   
}
