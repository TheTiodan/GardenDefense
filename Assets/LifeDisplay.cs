using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeDisplay : MonoBehaviour
{

    [SerializeField] int life = 10;
    Text lifeText;


    void Start()
    {
        life = Mathf.RoundToInt(life / PlayerPrefsController.GetMasterDifficulty());
        lifeText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        lifeText.text = life.ToString();
    }
    public void AddLife(int amount)
    {
        life = life + amount;
        UpdateDisplay();
    }
    public void LoseLife(int amount)
    {
        life = life - amount;
        UpdateDisplay();
        if (life <= 0)
        {
            LoseGame();
        }
    }
    public void LoseGame()
    {
        FindObjectOfType<LevelController>().HandleLoss();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
