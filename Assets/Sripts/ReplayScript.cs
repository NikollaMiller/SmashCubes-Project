using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ReplayScript : MonoBehaviour
{
    public static int SelectReplayLevel;
    public static int[] StarsForReplay = new int[30];
    public static int yeswanna = 0;

    public Text StarPerLevel;
    public Text StarPerLevelBG;

    public spuk spak;

    public GameObject replayBar;
    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;

    public void Start()
    {
        SelectReplayLevel = PlayerPrefs.GetInt("Selected");
       
        for (int i = 0; i < StarsForReplay.Length; i++)
        {
            StarsForReplay[i] = PlayerPrefs.GetInt($"Replaing{StarsForReplay[i]}", StarsForReplay[i]);
        }
    }

    public void Update()
    {
        PlayerPrefs.SetInt("Selected", SelectReplayLevel);
        if (SelectReplayLevel == 0 && StarsForReplay[0] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[0] + "/3";
            StarPerLevelBG.text = StarsForReplay[0] + "/3";
        }

        if (SelectReplayLevel == 0 && StarsForReplay[0] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[0] + "/3";
            StarPerLevelBG.text = StarsForReplay[0] + "/3";
        }

        if (SelectReplayLevel == 0 && StarsForReplay[0] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[0] + "/3";
            StarPerLevelBG.text = StarsForReplay[0] + "/3";
        }


        if (SelectReplayLevel == 1 && StarsForReplay[1] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[1] + "/3";
            StarPerLevelBG.text = StarsForReplay[1] + "/3";
        }

         if (SelectReplayLevel == 1 && StarsForReplay[1] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[1] + "/3";
            StarPerLevelBG.text = StarsForReplay[1] + "/3";
        }

        if (SelectReplayLevel == 1 && StarsForReplay[1] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[1] + "/3";
            StarPerLevelBG.text = StarsForReplay[1] + "/3";
        }


        if (SelectReplayLevel == 2 && StarsForReplay[2] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[2] + "/3";
            StarPerLevelBG.text = StarsForReplay[2] + "/3";
        }

         if (SelectReplayLevel == 2 && StarsForReplay[2] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[2] + "/3";
            StarPerLevelBG.text = StarsForReplay[2] + "/3";
        }

         if (SelectReplayLevel == 2 && StarsForReplay[2] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[2] + "/3";
            StarPerLevelBG.text = StarsForReplay[2] + "/3";
        }

        if (SelectReplayLevel == 3 && StarsForReplay[3] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[3] + "/3";
            StarPerLevelBG.text = StarsForReplay[3] + "/3";
        }

         if (SelectReplayLevel ==3 && StarsForReplay[3] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[3] + "/3";
            StarPerLevelBG.text = StarsForReplay[3] + "/3";
        }

        if (SelectReplayLevel == 3 && StarsForReplay[3] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[3] + "/3";
            StarPerLevelBG.text = StarsForReplay[3] + "/3";
        }

        if (SelectReplayLevel == 4 && StarsForReplay[4] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[4] + "/3";
            StarPerLevelBG.text = StarsForReplay[4] + "/3";
        }

        if (SelectReplayLevel == 4 && StarsForReplay[4] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[4] + "/3";
            StarPerLevelBG.text = StarsForReplay[4] + "/3";
        }

         if (SelectReplayLevel == 4 && StarsForReplay[4] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[4] + "/3";
            StarPerLevelBG.text = StarsForReplay[4] + "/3";
        }

         if (SelectReplayLevel == 5 && StarsForReplay[5] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[5] + "/3";
            StarPerLevelBG.text = StarsForReplay[5] + "/3";
        }

         if (SelectReplayLevel == 5 && StarsForReplay[5] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[5] + "/3";
            StarPerLevelBG.text = StarsForReplay[5] + "/3";
        }

        if (SelectReplayLevel == 5 && StarsForReplay[5] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[5] + "/3";
            StarPerLevelBG.text = StarsForReplay[5] + "/3";
        }

        if (SelectReplayLevel == 6 && StarsForReplay[6] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[6] + "/3";
            StarPerLevelBG.text = StarsForReplay[6] + "/3";
        }
         if (SelectReplayLevel == 6 && StarsForReplay[6] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[6] + "/3";
            StarPerLevelBG.text = StarsForReplay[6] + "/3";
        }
         if (SelectReplayLevel == 6 && StarsForReplay[6] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[6] + "/3";
            StarPerLevelBG.text = StarsForReplay[6] + "/3";
        }

         if (SelectReplayLevel == 7 && StarsForReplay[7] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[7] + "/3";
            StarPerLevelBG.text = StarsForReplay[7] + "/3";
        }

         if (SelectReplayLevel == 7 && StarsForReplay[7] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[7] + "/3";
            StarPerLevelBG.text = StarsForReplay[7] + "/3";
        }

         if (SelectReplayLevel == 7 && StarsForReplay[7] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[7] + "/3";
            StarPerLevelBG.text = StarsForReplay[7] + "/3";
        }
         if (SelectReplayLevel == 8 && StarsForReplay[8] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[8] + "/3";
            StarPerLevelBG.text = StarsForReplay[8] + "/3";
        }

         if (SelectReplayLevel == 8 && StarsForReplay[8] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[8] + "/3";
            StarPerLevelBG.text = StarsForReplay[8] + "/3";
        }

        if (SelectReplayLevel == 8 && StarsForReplay[8] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[8] + "/3";
            StarPerLevelBG.text = StarsForReplay[8] + "/3";
        }

         if (SelectReplayLevel == 9 && StarsForReplay[9] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[9] + "/3";
            StarPerLevelBG.text = StarsForReplay[9] + "/3";
        }

         if (SelectReplayLevel == 9 && StarsForReplay[9] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[9] + "/3";
            StarPerLevelBG.text = StarsForReplay[9] + "/3";
        }

        if (SelectReplayLevel == 9 && StarsForReplay[9] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[9] + "/3";
            StarPerLevelBG.text = StarsForReplay[9] + "/3";
        }

        if (SelectReplayLevel == 10 && StarsForReplay[10] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[10] + "/3";
            StarPerLevelBG.text = StarsForReplay[10] + "/3";
        }

         if (SelectReplayLevel == 10 && StarsForReplay[10] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[10] + "/3";
            StarPerLevelBG.text = StarsForReplay[10] + "/3";
        }

         if (SelectReplayLevel == 10 && StarsForReplay[10] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[10] + "/3";
            StarPerLevelBG.text = StarsForReplay[10] + "/3";
        }

         if (SelectReplayLevel == 11 && StarsForReplay[11] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[11] + "/3";
            StarPerLevelBG.text = StarsForReplay[11] + "/3";
        }

         if (SelectReplayLevel == 11 && StarsForReplay[11] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[11] + "/3";
            StarPerLevelBG.text = StarsForReplay[11] + "/3";
        }

         if (SelectReplayLevel == 11 && StarsForReplay[11] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[11] + "/3";
            StarPerLevelBG.text = StarsForReplay[11] + "/3";
        }

         if (SelectReplayLevel == 12 && StarsForReplay[12] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[12] + "/3";
            StarPerLevelBG.text = StarsForReplay[12] + "/3";
        }

         if (SelectReplayLevel == 12 && StarsForReplay[12] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[12] + "/3";
            StarPerLevelBG.text = StarsForReplay[12] + "/3";
        }

        if (SelectReplayLevel == 12 && StarsForReplay[12] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[12] + "/3";
            StarPerLevelBG.text = StarsForReplay[12] + "/3";
        }

         if (SelectReplayLevel == 13 && StarsForReplay[13] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[13] + "/3";
            StarPerLevelBG.text = StarsForReplay[13] + "/3";
        }

         if (SelectReplayLevel == 13 && StarsForReplay[13] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[13] + "/3";
            StarPerLevelBG.text = StarsForReplay[13] + "/3";
        }

         if (SelectReplayLevel == 13 && StarsForReplay[13] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[13] + "/3";
            StarPerLevelBG.text = StarsForReplay[13] + "/3";
        }

         if (SelectReplayLevel == 14 && StarsForReplay[14] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[14] + "/3";
            StarPerLevelBG.text = StarsForReplay[14] + "/3";
        }

        if (SelectReplayLevel == 14 && StarsForReplay[14] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[14] + "/3";
            StarPerLevelBG.text = StarsForReplay[14] + "/3";
        }

         if (SelectReplayLevel == 14 && StarsForReplay[14] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[14] + "/3";
            StarPerLevelBG.text = StarsForReplay[14] + "/3";
        }

         if (SelectReplayLevel == 15 && StarsForReplay[15] == 1 )
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[15] + "/3";
            StarPerLevelBG.text = StarsForReplay[15] + "/3";
        }

         if (SelectReplayLevel == 15 && StarsForReplay[15] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[15] + "/3";
            StarPerLevelBG.text = StarsForReplay[15] + "/3";
        }

        if (SelectReplayLevel == 15 && StarsForReplay[15] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[15] + "/3";
            StarPerLevelBG.text = StarsForReplay[15] + "/3";
        }

        if (SelectReplayLevel == 16 && StarsForReplay[16] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[16] + "/3";
            StarPerLevelBG.text = StarsForReplay[16] + "/3";
        }

         if (SelectReplayLevel == 16 && StarsForReplay[16] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[16] + "/3";
            StarPerLevelBG.text = StarsForReplay[16] + "/3";
        }

         if (SelectReplayLevel == 16 && StarsForReplay[16] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[16] + "/3";
            StarPerLevelBG.text = StarsForReplay[16] + "/3";
        }

        if (SelectReplayLevel == 17 && StarsForReplay[17] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[17] + "/3";
            StarPerLevelBG.text = StarsForReplay[17] + "/3";
        }

        if (SelectReplayLevel == 17 && StarsForReplay[17] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[17] + "/3";
            StarPerLevelBG.text = StarsForReplay[17] + "/3";
        }

        if (SelectReplayLevel == 17 && StarsForReplay[17] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[17] + "/3";
            StarPerLevelBG.text = StarsForReplay[17] + "/3";
        }

         if (SelectReplayLevel == 18 && StarsForReplay[18] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[18] + "/3";
            StarPerLevelBG.text = StarsForReplay[18] + "/3";
        }

        if (SelectReplayLevel == 18 && StarsForReplay[18] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[18] + "/3";
            StarPerLevelBG.text = StarsForReplay[18] + "/3";
        }

        if (SelectReplayLevel == 18 && StarsForReplay[18] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[18] + "/3";
            StarPerLevelBG.text = StarsForReplay[18] + "/3";
        }

        if (SelectReplayLevel == 19 && StarsForReplay[19] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[19] + "/3";
            StarPerLevelBG.text = StarsForReplay[19] + "/3";
        }

        if (SelectReplayLevel == 19 && StarsForReplay[19] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[19] + "/3";
            StarPerLevelBG.text = StarsForReplay[19] + "/3";
        }

        if (SelectReplayLevel == 19 && StarsForReplay[19] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[19] + "/3";
            StarPerLevelBG.text = StarsForReplay[19] + "/3";
        }

        if (SelectReplayLevel == 20 && StarsForReplay[20] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[20] + "/3";
            StarPerLevelBG.text = StarsForReplay[20] + "/3";
        }

        if (SelectReplayLevel == 20 && StarsForReplay[20] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[20] + "/3";
            StarPerLevelBG.text = StarsForReplay[20] + "/3";
        }

        if (SelectReplayLevel == 20 && StarsForReplay[20] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[20] + "/3";
            StarPerLevelBG.text = StarsForReplay[20] + "/3";
        }

        if (SelectReplayLevel == 21 && StarsForReplay[21] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[21] + "/3";
            StarPerLevelBG.text = StarsForReplay[21] + "/3";
        }

        if (SelectReplayLevel == 21 && StarsForReplay[21] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[21] + "/3";
            StarPerLevelBG.text = StarsForReplay[21] + "/3";
        }

        if (SelectReplayLevel == 21 && StarsForReplay[21] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[21] + "/3";
            StarPerLevelBG.text = StarsForReplay[21] + "/3";
        }

        if (SelectReplayLevel == 22 && StarsForReplay[22] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[22] + "/3";
            StarPerLevelBG.text = StarsForReplay[22] + "/3";
        }

        if (SelectReplayLevel == 22 && StarsForReplay[22] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[22] + "/3";
            StarPerLevelBG.text = StarsForReplay[22] + "/3";
        }

        if (SelectReplayLevel == 22 && StarsForReplay[22] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[22] + "/3";
            StarPerLevelBG.text = StarsForReplay[22] + "/3";
        }

        if (SelectReplayLevel == 23 && StarsForReplay[23] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[23] + "/3";
            StarPerLevelBG.text = StarsForReplay[23] + "/3";
        }

        if (SelectReplayLevel == 23 && StarsForReplay[23] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[23] + "/3";
            StarPerLevelBG.text = StarsForReplay[23] + "/3";
        }

        if (SelectReplayLevel == 23 && StarsForReplay[23] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[23] + "/3";
            StarPerLevelBG.text = StarsForReplay[23] + "/3";
        }

        if (SelectReplayLevel == 24 && StarsForReplay[24] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[24] + "/3";
            StarPerLevelBG.text = StarsForReplay[24] + "/3";
        }

         if (SelectReplayLevel == 24 && StarsForReplay[24] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[24] + "/3";
            StarPerLevelBG.text = StarsForReplay[24] + "/3";
        }

        if (SelectReplayLevel == 24 && StarsForReplay[24] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[24] + "/3";
            StarPerLevelBG.text = StarsForReplay[24] + "/3";
        }

         if (SelectReplayLevel == 25 && StarsForReplay[25] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[25] + "/3";
            StarPerLevelBG.text = StarsForReplay[25] + "/3";
        }

         if (SelectReplayLevel == 25 && StarsForReplay[25] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[25] + "/3";
            StarPerLevelBG.text = StarsForReplay[25] + "/3";
        }

         if (SelectReplayLevel == 25 && StarsForReplay[25] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[25] + "/3";
            StarPerLevelBG.text = StarsForReplay[25] + "/3";
        }

         if (SelectReplayLevel == 26 && StarsForReplay[26] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[26] + "/3";
            StarPerLevelBG.text = StarsForReplay[26] + "/3";
        }
         if (SelectReplayLevel == 26 && StarsForReplay[26] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[26] + "/3";
            StarPerLevelBG.text = StarsForReplay[26] + "/3";
        }

         if (SelectReplayLevel == 26 && StarsForReplay[26] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[26] + "/3";
            StarPerLevelBG.text = StarsForReplay[26] + "/3";
        }


         if (SelectReplayLevel == 27 && StarsForReplay[27] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[27] + "/3";
            StarPerLevelBG.text = StarsForReplay[27] + "/3";
        }

         if (SelectReplayLevel == 27 && StarsForReplay[27] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[27] + "/3";
            StarPerLevelBG.text = StarsForReplay[27] + "/3";
        }

         if (SelectReplayLevel == 27 && StarsForReplay[27] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[27] + "/3";
            StarPerLevelBG.text = StarsForReplay[27] + "/3";
        }

         if (SelectReplayLevel == 28 && StarsForReplay[28] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[28] + "/3";
            StarPerLevelBG.text = StarsForReplay[28] + "/3";
        }

        if (SelectReplayLevel == 28 && StarsForReplay[28] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[28] + "/3";
            StarPerLevelBG.text = StarsForReplay[28] + "/3";
        }

         if (SelectReplayLevel == 28 && StarsForReplay[28] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[28] + "/3";
            StarPerLevelBG.text = StarsForReplay[28] + "/3";
        }

         if (SelectReplayLevel == 29 && StarsForReplay[29] == 1)
        {
            Star1.SetActive(true);
            Star2.SetActive(false);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[29] + "/3";
            StarPerLevelBG.text = StarsForReplay[29] + "/3";
        }

         if (SelectReplayLevel == 29 && StarsForReplay[29] == 2)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(false);
            StarPerLevel.text = StarsForReplay[29] + "/3";
            StarPerLevelBG.text = StarsForReplay[29] + "/3";
        }
         if (SelectReplayLevel == 29 && StarsForReplay[29] == 3)
        {
            Star1.SetActive(true);
            Star2.SetActive(true);
            Star3.SetActive(true);
            StarPerLevel.text = StarsForReplay[29] + "/3";
            StarPerLevelBG.text = StarsForReplay[29] + "/3";
        }

    }


    public void SelectForReplayLevel(int Selected)
    {
        Debug.Log(SelectReplayLevel);
        SelectReplayLevel = Selected;
        replayBar.SetActive(true);
    }
    public void CloseReplayBar() 
    {
        SelectReplayLevel = 0;
        yeswanna = 0;
        PlayerPrefs.SetInt("AGUSHA", yeswanna);
    }

    public void SelectReplayLevelOne() 
    {
        for (int i = 0; i < 1; i++)
        {
            if (SelectReplayLevel == i)
            {
              StarSystem.AllStars = StarSystem.AllStars - StarsForReplay[i];
              yeswanna = 1;
            }
        }
        Debug.Log(yeswanna);
        PlayerPrefs.SetInt("AGUSHA", yeswanna);
        Invoke("odna", 1);
        spak.enabled = true;
    }

    private void odna() 
    {
        SceneManager.LoadScene(1);
    }
}
