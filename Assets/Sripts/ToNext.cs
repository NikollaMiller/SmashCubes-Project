using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToNext : MonoBehaviour
{
    public GameObject del;
    public GameObject notEnoughStars;
    public Transform buttonPos;

    public void Start()
    {  
    }
    public void Next() 
    {
        if (LevelSystem.LevelSelected == 0) 
        {
            StarSystem.Comepleted[0] = 0;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[0] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if (LevelSystem.LevelSelected == 1)
        {
            StarSystem.Comepleted[1] = 1;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[1] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 2)
        {
            StarSystem.Comepleted[2] = 2;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[2] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 3)
        {
            StarSystem.Comepleted[3] = 3;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[3] =StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 4)
        {
            StarSystem.Comepleted[4] = 4;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[4] =StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 5)
        {
            StarSystem.Comepleted[5] = 5;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[5] =StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 6)
        {
            StarSystem.Comepleted[6] = 6;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[6] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 7)
        {
            StarSystem.Comepleted[7] = 7;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[7] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 8)
        {
            StarSystem.Comepleted[8] = 8;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[8] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 9)
        {
            StarSystem.Comepleted[9] = 9;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[9] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 10)
        {
            StarSystem.Comepleted[10] = 10;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[10] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 11)
        {
            StarSystem.Comepleted[11] = 11;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[11] =  StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 12)
        {
            StarSystem.Comepleted[12] = 12;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[12] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 13)
        {
            StarSystem.Comepleted[13] = 13;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[13] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 14)
        {
            StarSystem.Comepleted[14] = 14;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[14] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 15)
        {
            StarSystem.Comepleted[15] = 15;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[15] =StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 16)
        {
            StarSystem.Comepleted[16] = 16;
            Debug.Log(LevelSystem.LevelSelected);
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[16] = StarEarn.Stars;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 17)
        {
            StarSystem.Comepleted[17] = 17;
            Debug.Log(LevelSystem.LevelSelected);
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[17] = StarEarn.Stars;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 18)
        {
            StarSystem.Comepleted[18] = 18;
            Debug.Log(LevelSystem.LevelSelected);
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[18] = StarEarn.Stars;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 19)
        {
            StarSystem.Comepleted[19] = 19;
            LevelSystem.LevelSelected += 1;
            Debug.Log(LevelSystem.LevelSelected);
            ReplayScript.StarsForReplay[19] = StarEarn.Stars;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 20)
        {
            StarSystem.Comepleted[20] = 20;
            LevelSystem.LevelSelected += 1;
            Debug.Log(LevelSystem.LevelSelected);
            ReplayScript.StarsForReplay[20] = StarEarn.Stars;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 21)
        {
            StarSystem.Comepleted[21] = 21;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[21] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 22)
        {
            StarSystem.Comepleted[22] = 22;
            Debug.Log(LevelSystem.LevelSelected);
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[22] = StarEarn.Stars;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 23)
        {
            StarSystem.Comepleted[23] = 23;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[23] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 24)
        {
            StarSystem.Comepleted[24] = 24;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[24] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 25)
        {
            StarSystem.Comepleted[25] = 25;
            LevelSystem.LevelSelected += 1;
            ReplayScript.StarsForReplay[25] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 26)
        {
            StarSystem.Comepleted[26] = 26;
            ReplayScript.StarsForReplay[26] = StarEarn.Stars;
            Debug.Log(LevelSystem.LevelSelected);
            LevelSystem.LevelSelected += 1;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 27)
        {
            StarSystem.Comepleted[27] = 27;
            Debug.Log(LevelSystem.LevelSelected);
            ReplayScript.StarsForReplay[27] = StarEarn.Stars;
            LevelSystem.LevelSelected += 1;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 28)
        {
            StarSystem.Comepleted[28] = 28;
            Debug.Log(LevelSystem.LevelSelected);
            ReplayScript.StarsForReplay[28] = StarEarn.Stars;
            LevelSystem.LevelSelected +=1;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        else if(LevelSystem.LevelSelected == 29)
        {
            StarSystem.Comepleted[29] = 29;
            Debug.Log(LevelSystem.LevelSelected);
            ReplayScript.StarsForReplay[29] = StarEarn.Stars;
            LevelSystem.LevelSelected = 0;
            StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        }
        PlayerPrefs.SetInt("Lvls", LevelSystem.LevelSelected);
        PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        for (int i = 0; i < StarSystem.Comepleted.Length; i++)
        {
            PlayerPrefs.SetInt($"come{StarSystem.Comepleted[i]}", StarSystem.Comepleted[i]);
        }
        for (int i = 0; i < ReplayScript.StarsForReplay.Length; i++)
        {
            PlayerPrefs.SetInt($"Replaing{ReplayScript.StarsForReplay[i]}", ReplayScript.StarsForReplay[i]);
        }
        Invoke("nextik", 1.8f);
    }

    public void Again() 
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
        del.SetActive(false);
    }

    public void NExtStage()
    {

        if (StarSystem.AllStars >= 12)
        {
            int scene = SceneManager.GetActiveScene().buildIndex;
            scene = scene + 1;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
        }
        else 
        {
            Instantiate(notEnoughStars,buttonPos);
            notEnoughStars.SetActive(true);
        }

    }

    public void nextik() 
    {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void Stagers() 
    {
        StarSystem.AllStars = StarSystem.AllStars + StarEarn.Stars;
        PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
    }
}
