using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarSystem : MonoBehaviour
{
    public Text AllStarsTrack;
    public Text AllStarsTrackBG;

    public Text ToNExtAge;

    public GameObject[] UnlockStage;
    public GameObject[] BlackPage;
    public GameObject[] Complete;
    public GameObject[] NotEnoughtStars;
    public Transform[] ButtonPos;

    public static int AllStars;
    public int[] saveUnlockedStage;
    public static int[] Comepleted = new int[30];
    private int Plus = 12;

    public void Start()
    {
        NotEnoughtStars[0].SetActive(false);
        NotEnoughtStars[1].SetActive(false);
        AllStars = PlayerPrefs.GetInt("AllStar");
        saveUnlockedStage[0] = PlayerPrefs.GetInt("saveUnlockedStage");
        saveUnlockedStage[1] = PlayerPrefs.GetInt("saveUnlockedStage1");
        for (int i = 0; i < Comepleted.Length; i++)
        {
            Comepleted[i] = PlayerPrefs.GetInt($"come{Comepleted[i]}");
        }
    }

    public void Update()
    {
        if (AllStars<0) 
        {
            AllStars = 0;
        }
        if (Comepleted[0] == 0)
        {
            Complete[0].SetActive(true);
            BlackPage[0].SetActive(false);
            BlackPage[1].SetActive(false);
        }
        if (Comepleted[1] == 1)
        {
            Complete[1].SetActive(true);
            BlackPage[1].SetActive(false);
            BlackPage[2].SetActive(false);
        }
        if (Comepleted[2] == 2)
        {
            Complete[2].SetActive(true);
            BlackPage[2].SetActive(false);
            BlackPage[3].SetActive(false);
        }

        if (Comepleted[3] == 3)
        {
            Complete[3].SetActive(true);
            BlackPage[3].SetActive(false);
            BlackPage[4].SetActive(false);
        }

        if (Comepleted[4] ==4)
        {
            Complete[4].SetActive(true);
            BlackPage[4].SetActive(false);
            BlackPage[5].SetActive(false);
        }

        if (Comepleted[5] == 5)
        {
            Complete[5].SetActive(true);
            BlackPage[5].SetActive(false);
            BlackPage[6].SetActive(false);
        }

        if (Comepleted[6] == 6)
        {
            Complete[6].SetActive(true);
            BlackPage[6].SetActive(false);
            BlackPage[7].SetActive(false);
        }

        if (Comepleted[7] == 7)
        {
            Complete[7].SetActive(true);
            BlackPage[7].SetActive(false);
            BlackPage[8].SetActive(false);
        }

        if (Comepleted[8] == 8)
        {
            Complete[8].SetActive(true);
            BlackPage[8].SetActive(false);
            BlackPage[9].SetActive(false);
        }

        if (Comepleted[9] == 9)
        {
            Complete[9].SetActive(true);
            BlackPage[9].SetActive(false);
            BlackPage[10].SetActive(false);
        }

        if (Comepleted[10] == 10)
        {
            Complete[10].SetActive(true);
            BlackPage[10].SetActive(false);
            BlackPage[11].SetActive(false);
        }

        if (Comepleted[11] == 11)
        {
            Complete[11].SetActive(true);
            BlackPage[11].SetActive(false);
            BlackPage[12].SetActive(false);
        }

        if (Comepleted[12] == 12)
        {
            Complete[12].SetActive(true);
            BlackPage[12].SetActive(false);
            BlackPage[13].SetActive(false);
        }

        if (Comepleted[13] == 13)
        {
            Complete[13].SetActive(true);
            BlackPage[13].SetActive(false);
            BlackPage[14].SetActive(false);
        }

        if (Comepleted[14] == 14)
        {
            Complete[14].SetActive(true);
            BlackPage[14].SetActive(false);
            BlackPage[15].SetActive(false);
        }

        if (Comepleted[15] == 15)
        {
            Complete[15].SetActive(true);
            BlackPage[15].SetActive(false);
            BlackPage[16].SetActive(false);
        }

        if (Comepleted[16] == 16)
        {
            Complete[16].SetActive(true);
            BlackPage[16].SetActive(false);
            BlackPage[17].SetActive(false);
        }

        if (Comepleted[17] == 17)
        {
            Complete[17].SetActive(true);
            BlackPage[17].SetActive(false);
            BlackPage[18].SetActive(false);
        }

        if (Comepleted[18] == 18)
        {
            Complete[18].SetActive(true);
            BlackPage[18].SetActive(false);
            BlackPage[19].SetActive(false);
        }

        if (Comepleted[19] == 19)
        {
            Complete[19].SetActive(true);
            BlackPage[19].SetActive(false);
            BlackPage[20].SetActive(false);
        }

        if (Comepleted[20] == 20)
        {
            Complete[20].SetActive(true);
            BlackPage[20].SetActive(false);
            BlackPage[21].SetActive(false);
        }

        if (Comepleted[21] == 21)
        {
            Complete[21].SetActive(true);
            BlackPage[21].SetActive(false);
            BlackPage[22].SetActive(false);
        }

        if (Comepleted[22] == 22)
        {
            Complete[22].SetActive(true);
            BlackPage[22].SetActive(false);
            BlackPage[23].SetActive(false);
        }

        if (Comepleted[23] == 23)
        {
            Complete[23].SetActive(true);
            BlackPage[23].SetActive(false);
            BlackPage[24].SetActive(false);
        }

        if (Comepleted[24] == 24)
        {
            Complete[24].SetActive(true);
            BlackPage[24].SetActive(false);
            BlackPage[25].SetActive(false);
        }

        if (Comepleted[25] == 25)
        {
            Complete[25].SetActive(true);
            BlackPage[25].SetActive(false);
            BlackPage[26].SetActive(false);
        }

        if (Comepleted[26] == 27)
        {
            Complete[26].SetActive(true);
            BlackPage[26].SetActive(false);
            BlackPage[27].SetActive(false);
        }

        if (Comepleted[27] == 27)
        {
            Complete[27].SetActive(true);
            BlackPage[27].SetActive(false);
            BlackPage[28].SetActive(false);
        }

        if (Comepleted[28] == 28)
        {
            Complete[28].SetActive(true);
            BlackPage[28].SetActive(false);
            BlackPage[29].SetActive(false);
        }

        if (Comepleted[29] == 29)
        {
            Complete[29].SetActive(true);
            BlackPage[29].SetActive(false);
        }

        ToNExtAge.text = Plus - AllStars + "X";

        if (saveUnlockedStage[0] == 1) 
        {
            UnlockStage[0].SetActive(false);
            BlackPage[11].SetActive(false);
            BlackPage[12].SetActive(false);
            BlackPage[13].SetActive(false);
            BlackPage[14].SetActive(false);
            BlackPage[15].SetActive(false);
            BlackPage[16].SetActive(false);
            BlackPage[17].SetActive(false);
            BlackPage[18].SetActive(false);
            BlackPage[19].SetActive(false);
            BlackPage[20].SetActive(false);

        }

        if (saveUnlockedStage[1] == 2)
        {
            UnlockStage[1].SetActive(false);
            BlackPage[21].SetActive(false);
            BlackPage[22].SetActive(false);
            BlackPage[23].SetActive(false);
            BlackPage[24].SetActive(false);
            BlackPage[25].SetActive(false);
            BlackPage[26].SetActive(false);
            BlackPage[27].SetActive(false);
            BlackPage[28].SetActive(false);
            BlackPage[29].SetActive(false);
        }

        PlayerPrefs.SetInt("saveUnlockedStage", saveUnlockedStage[0]);
        PlayerPrefs.SetInt("saveUnlockedStage1", saveUnlockedStage[1]);
        PlayerPrefs.SetInt("AllStar", AllStars);
        for (int i = 0; i < Comepleted.Length; i++)
        {
            PlayerPrefs.SetInt($"come{Comepleted[i]}", Comepleted[i]);
        }

        AllStarsTrackBG.text = "X" + AllStars;
        AllStarsTrack.text = "X" + AllStars;
    }

    public void UnlockStageOne() 
    {
        if (AllStars >= Plus)
        {
            saveUnlockedStage[0] = 1;
            AllStars = AllStars - Plus;
            Plus = Plus + 1;
        }
        else 
        {
            Instantiate(NotEnoughtStars[0], ButtonPos[0]);
            NotEnoughtStars[0].SetActive(true);
        }
    }

    public void UnlockStageTwo() 
    {
        if (AllStars >= Plus)
        {
            saveUnlockedStage[0] = 1;
            AllStars = AllStars - Plus;
            Plus = Plus + 1;
        }
        else
        {
            Instantiate(NotEnoughtStars[1], ButtonPos[1]);
            NotEnoughtStars[1].SetActive(true);
        }
    }
}
