using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MineralDisplay : MonoBehaviour
{
    [SerializeField] int minerals = 100;
    Text mineralText;
    void Start()
    {
        mineralText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        mineralText.text = minerals.ToString();
    }
    public void AddMinerals(int amount)
    {
        minerals = minerals + amount;
        UpdateDisplay();
    }
    public void SpendMinerals(int amount)
    {
        if(minerals > amount)
        {
            minerals = minerals - amount;
            UpdateDisplay();
        }
        else
        {
            Debug.Log("Not enough Minerals!");
        }

    }

    

}
