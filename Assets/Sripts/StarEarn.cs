using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class StarEarn : MonoBehaviour
{
    public static int Stars;
    private int intik;

    public Text starTrack;
    public Text StarTrackBG;

    public Text AfterWon;
    public Text AfterWonBG;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    public Text ReplayedStarTrack;
    public Text ReplayedStarTrackBg;

    public GameObject StarReplay1;
    public GameObject StarReplay2;
    public GameObject StarReplay3;

    public GameObject Double;
    public GameObject HaventAd;
    public GameObject DoubleBar;
    public void Start()
    {
        Stars = 0;
    }
    public void Update()
    {

        if (Stars > 0)
        {
            Double.SetActive(true);
        }
        else
        {
            Double.SetActive(false);
        }


        starTrack.text = "X" + Stars + "/3";
        StarTrackBG.text = "X" + Stars + "/3";

        AfterWon.text = Stars + "/3";
        AfterWonBG.text = Stars + "/3";

        if (Stars == 1) 
        {
            star1.SetActive(true);
            star2.SetActive(false);
            star3.SetActive(false);
        }
        if (Stars == 2)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(false);
        }
        if (Stars == 3)
        {
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
        }

        ReplayedStarTrack.text = Stars + "/3";
        ReplayedStarTrackBg.text = Stars + "/3";

        if (Stars == 1)
        {
            StarReplay1.SetActive(true);
            StarReplay2.SetActive(false);
            StarReplay3.SetActive(false);
        }
        if (Stars == 2)
        {
            StarReplay1.SetActive(true);
            StarReplay2.SetActive(true);
            StarReplay3.SetActive(false);
        }
        if (Stars == 3)
        {
            StarReplay1.SetActive(true);
            StarReplay2.SetActive(true);
            StarReplay3.SetActive(true);
        }


    }

    public void DoubleBtn() 
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("rewardedVideo");
            Stars = Stars * 2;
            Double.SetActive(false);
            DoubleBar.SetActive(false);
        }
        else 
        {
            HaventAd.SetActive(true);
        }
    }
}
