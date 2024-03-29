﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master volume";
    const string MASTER_DIFFICULTY_KEY = "difficulty";
    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;
    const int MIN_DIFFICULTY = 1;
    const int MAX_DIFFICULTY = 5;

    public static void SetMasterVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master volume is out of Range");
        }
    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    
    public static void SetMasterDifficulty(int difficulty)
    {
        if (difficulty >= MIN_DIFFICULTY && difficulty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetInt(MASTER_DIFFICULTY_KEY, difficulty);
        }
        else
        {
            Debug.LogError("Master difficulty is out of Range");
        }
    }
    public static int GetMasterDifficulty()
    {
        return PlayerPrefs.GetInt(MASTER_DIFFICULTY_KEY);
    }
}
