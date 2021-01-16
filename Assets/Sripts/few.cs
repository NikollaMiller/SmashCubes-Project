using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class few : MonoBehaviour
{
    public GameObject pauseBn;
    public void Start()
    {
       ReplayScript.SelectReplayLevel = PlayerPrefs.GetInt("Selected");
       Debug.Log(ReplayScript.SelectReplayLevel);

        for (int i = 0; i < ReplayScript.SelectReplayLevel; i++)
        {
            if (ReplayScript.SelectReplayLevel == i)
            {
                pauseBn.SetActive(false);
            }
        }
    }
    public void EndReplay() 
    {
        for (int i = 0; i < ReplayScript.SelectReplayLevel; i++)
        {
            ReplayScript.StarsForReplay[i] = StarEarn.Stars;
            PlayerPrefs.SetInt($"Replaing{ReplayScript.StarsForReplay[i]}", ReplayScript.StarsForReplay[i]);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
            PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        }
    }
}
