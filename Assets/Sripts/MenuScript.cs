using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject Tutorial;
    public int AfterTutorial;
    public GameObject mENU;
    public GameObject pl;
    public Spawner spawner;
    public GameObject StarCounter;
    public GameObject LevelList;
    public GameObject ShopBtn;
    public GameObject BonusGameBtnka;

   // public Slider Charge;
    public Slider OffFall;

    public void Start()
    {
        OffFall.value = PlayerPrefs.GetFloat("fall", OffFall.value);
        AfterTutorial = PlayerPrefs.GetInt("AfterTutorial");
     // Charge.value = PlayerPrefs.GetFloat("Charge", Charge.value);        
        if (AfterTutorial == 1)
        {
            ShopBtn.SetActive(true);
            Tutorial.SetActive(false);
            mENU.SetActive(true);
            pl.SetActive(true);
            StarCounter.SetActive(true);
            BonusGameBtnka.SetActive(true);
            OffFall.value = 1;
        }
        else 
        {
            BonusGameBtnka.SetActive(false);
            ShopBtn.SetActive(false);
            StarCounter.SetActive(false);
            Tutorial.SetActive(true);
            mENU.SetActive(false);
            OffFall.value = 0;
        }
    }

    public void Update()
    {

        PlayerPrefs.SetFloat("fall", OffFall.value);
       // PlayerPrefs.SetFloat("Charge",Charge.value);
        if (OffFall.value == 1)
        {
            spawner.enabled = true;
        }
        else
        {
            spawner.enabled = false;
        }
    }

    public void Play() 
    {
        PlayerPrefs.SetInt("Selected", ReplayScript.SelectReplayLevel);
        ReplayScript.SelectReplayLevel = 0;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void EndTutorial() 
    {
        AfterTutorial = 1;
        PlayerPrefs.SetInt("AfterTutorial", AfterTutorial);
        mENU.SetActive(true);
        Tutorial.SetActive(false);
        SceneManager.LoadScene("Menu");
    }

    public void OffFalling() 
    {
        spawner.GetComponent<Spawner>().enabled = !spawner.GetComponent<Spawner>().enabled;
    }

    public void ToLevelList() 
    {
        mENU.SetActive(false);
        LevelList.SetActive(true);
    }
}
