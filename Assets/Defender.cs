using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int mineralCost = 100;

    public void AddMinerals(int amount)
    {
        FindObjectOfType<MineralDisplay>().AddMinerals(amount);
    }
    public int GetMineralCost()
    {
        return mineralCost;
    }


}
