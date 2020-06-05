using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Level Timer in Seconds")] 
    [SerializeField] float levelTime = 10;
    public bool timerFinished = false;
    bool triggeredLevelFinished = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(triggeredLevelFinished)
        { return; }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelTime;
        timerFinished = (Time.timeSinceLevelLoad >= levelTime);
        if (timerFinished)
        {
            Debug.Log("Timer Finished");
            FindObjectOfType<LevelController>().LevelTimerFinished();
            StopSpawners();
            triggeredLevelFinished = true;
        }
    }
    private void StopSpawners()
    {
        AttackerSpawner[] attackerspawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner attackerSpawner in attackerspawners)
        {
            attackerSpawner.StopAllCoroutines();
        }
    }
}
