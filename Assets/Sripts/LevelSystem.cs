using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public static int LevelSelected;

    public void Start()
    {
        LevelSelected = PlayerPrefs.GetInt("Lvls");
    }

    private void Update()
    {
        PlayerPrefs.SetInt("Lvls",LevelSelected);
    }

    public void Lvl1(int lvl) 
    {
        LevelSelected = lvl;
    }
}
