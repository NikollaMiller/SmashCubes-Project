using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class BonusGameCont : MonoBehaviour
{
    [SerializeField] private Text timer;
    [SerializeField] private Text[] texta;
    [SerializeField] private GameObject reboot;
    [SerializeField] private GameObject textik;
    [SerializeField] private GameObject replaybar;
    [SerializeField] private Text AboutText;
    [SerializeField] private Text[] variants;
    [SerializeField] private Text Try;
    [SerializeField] private Text replay;
    [SerializeField] private GameObject HaveNotConnection;
    [SerializeField] private Text[] checkInternet;
    private int x = 1;
    private float second = 1;
    private int trying = 0;
    private int dostig;

    private void Start()
    {
        trying = PlayerPrefs.GetInt("try",trying);
        Time.timeScale = 0;
        if (Application.systemLanguage == SystemLanguage.Russian) 
        {
            for (int i = 0; i < checkInternet.Length; i++)
            {
                checkInternet[i].text = "ПРОВЕРЬТЕ ПОДКЛЮЧЕНИЕ К ИНТЕРНЕТУ";
            }
            replay.text = "Переиграть";
            texta[1].text ="Бонусная игра";
            AboutText.text = "Желаете переиграть?";
            variants[0].text = "Да";
            variants[1].text = "Нет";
        }
        else if (Application.systemLanguage == SystemLanguage.Korean)
        {
            for (int i = 0; i < checkInternet.Length; i++)
            {
                checkInternet[i].text = "인터넷 연결 확인";
            }
            replay.text = "다시 하다";
            texta[1].text = "보너스 게임";
            AboutText.text = "다시 재생 하시겠습니까?";
            variants[0].text = "예";
            variants[1].text = "아니";
        }
        else if (Application.systemLanguage == SystemLanguage.German)
        {
            for (int i = 0; i < checkInternet.Length; i++)
            {
                checkInternet[i].text = "Überprüfen Sie Ihre Verbindung zum Internet";
            }
            replay.text = "Wiederholung";
            texta[1].text = "Bonusspiel";
            AboutText.text = "Möchten Sie wiederholen?";
            variants[0].text = "Ja";
            variants[1].text = "Nein";
        }
        else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
        {
            for (int i = 0; i < checkInternet.Length; i++)
            {
                checkInternet[i].text = "檢查您的互聯網連接";
            }
            replay.text = "重播";
            texta[1].text = "奖励游戏";
            AboutText.text = "您想重播吗？";
            variants[0].text = "是";
            variants[1].text = "没有";
        }
        else
        {
            for (int i = 0; i < checkInternet.Length; i++)
            {
                checkInternet[i].text = "CHECK YOUR CONNECT TO INTENRNET";
            }
            replay.text = "REPLAY";
            texta[1].text = "BONUS GAME";
            AboutText.text = "Do you want to replay?";
            variants[0].text = "YES";
            variants[1].text = "NO";
        }
    }

    private void Update()
    {
        PlayerPrefs.SetInt("AllStar", StarSystem.AllStars);
        PlayerPrefs.SetInt("try", trying);
        second += 1 * Time.deltaTime;
        x = Convert.ToInt32(second);
        timer.text = x + "s";
        if (CubesMakeDamage.aga <= 0)
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                texta[0].text = "ПРОИГРАЛ";
            }
            else if (Application.systemLanguage == SystemLanguage.Korean)
            {
                texta[0].text = "플레이";
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                texta[0].text = "Gespielt";
            }
            else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
            {
                texta[0].text = "玩过";
            }
            else
            {
                texta[0].text = "Loose";
            }
            Time.timeScale = 0;
            CubesMakeDamage.aga = 0;
            reboot.SetActive(true);
        }
        else
        {
            texta[0].text = "";
            reboot.SetActive(false);
        }

        if (x % 20 == 0)
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                texta[0].text = "20 ЗВЕЗД ПОЛУЧЕНО";
            }
            else if (Application.systemLanguage == SystemLanguage.Korean)
            {
                texta[0].text = "별 20 개 받음";
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                texta[0].text = "20 STERNE ERHALTEN";
            }
            else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
            {
                texta[0].text = "收到20星";
            }
            else
            {
                texta[0].text = "20 STARS RECEIVED";
            }
            dostig +=Convert.ToInt32(1 *Time.deltaTime);
        }
        else 
        {
            texta[0].text = "";
        }

        if (Application.systemLanguage == SystemLanguage.Russian) 
        {
            Try.text = "ПОПЫТОК " + trying + " из 3";
        }
        else if (Application.systemLanguage == SystemLanguage.German)
        {
            Try.text = "Versuche " + trying + " von 3";
        }
        else if (Application.systemLanguage == SystemLanguage.Korean)
        {
            Try.text = trying + "/3" + " 시도";
        }
        else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
        {
            Try.text = "尝试 " + trying + " 的 3";
        }
        else
        {
            Try.text = "ATTEMPT " + trying + " of 3";
        }
        if (trying > 3)
        {
            replaybar.SetActive(true);
            reboot.SetActive(false);
            texta[0].text = "";
        }
        else 
        {
            replaybar.SetActive(false);
        }

    }

    public void Reboot() 
    {
        if (x > 0) 
        {
            StarSystem.AllStars += 20;
        }

        trying += 1;
        if (trying > 3)
        {
            replaybar.SetActive(true);
        }
        else 
        {
            replaybar.SetActive(false);
            var sceen = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceen,LoadSceneMode.Single);
        }
    }

    public void StartBTN() 
    {
        textik.SetActive(false);
        Time.timeScale = 1;
    }

    public void YesReplay() 
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");
            trying = 0;
            var sceen = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceen, LoadSceneMode.Single);
            HaveNotConnection.SetActive(false);
        }
        else 
        {
            HaveNotConnection.SetActive(true);
        }
    }
    public void NotRepaly() 
    {
        trying = 0;
        SceneManager.LoadScene("Menu");
    }
}
