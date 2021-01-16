using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
public class SpriteControl : MonoBehaviour
{
    public MeshRenderer[] meshtheme;
    public Material[] materials;
    public Image[] SwipeMenuTheme;
    public Sprite[] MenuThemeOrange;
    public Sprite[] MenuThemeRed;
    public Sprite[] MenuthemeDefault;

    private int replayed;

    public Text levlCount;
    public Text levlCountBG;
    private int smenka;

    public Font[] fnts;

    public void Start()
    {
        if (Application.systemLanguage == SystemLanguage.Japanese)
        {
            levlCount.text = "リプレイレベル " + replayed;
            levlCountBG.text = "リプレイレベル " + replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }
        else if (Application.systemLanguage == SystemLanguage.Russian) 
        {
            levlCount.text = "УРОВЕНЬ ДЛЯ ПЕРЕИГРЫВАНИЯ " + replayed;
            levlCountBG.text = "УРОВЕНЬ ДЛЯ ПЕРЕИГРЫВАНИЯ " + replayed;
            levlCount.font = fnts[0];
            levlCountBG.font = fnts[0];

        }
        else if (Application.systemLanguage == SystemLanguage.Korean)
        {
            levlCount.text = "레벨 재생 " + replayed;
            levlCountBG.text = "레벨 재생 " +replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }
        else if (Application.systemLanguage == SystemLanguage.English)
        {
            levlCount.text = "REPLAY LVL " + replayed;
            levlCountBG.text = "REPLAY LVL " + replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }
    }

    public void Update()
    {
        if (Application.systemLanguage == SystemLanguage.Japanese)
        {
            levlCount.text = "リプレイレベル " + replayed;
            levlCountBG.text = "リプレイレベル " + replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }
        else if (Application.systemLanguage == SystemLanguage.Russian)
        {
            levlCount.text = "УРОВЕНЬ ДЛЯ ПЕРЕИГРЫВАНИЯ " + replayed;
            levlCountBG.text = "УРОВЕНЬ ДЛЯ ПЕРЕИГРЫВАНИЯ " + replayed;
            levlCount.font = fnts[0];
            levlCountBG.font = fnts[0];

        }
        else if (Application.systemLanguage == SystemLanguage.Korean)
        {
            levlCount.text = "레벨 재생 " + replayed;
            levlCountBG.text = "레벨 재생 " + replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }
        else if (Application.systemLanguage == SystemLanguage.English)
        {
            levlCount.text = "REPLAY LVL " + replayed;
            levlCountBG.text = "REPLAY LVL " + replayed;
            levlCount.font = fnts[1];
            levlCountBG.font = fnts[1];
        }

        if (smenka == 2)
        {
            for (int i = 0; i < meshtheme.Length; i++)
            {
                meshtheme[i].material = materials[0]; 
            }
            for (int i = 0; i < SwipeMenuTheme.Length; i++)
            {
                SwipeMenuTheme[i].sprite = MenuThemeOrange[i];
            }
        }
        else if (smenka == 3)
        {
            for (int i = 0; i < meshtheme.Length; i++)
            {
                meshtheme[i].material = materials[1];
            }
            for (int i = 0; i < SwipeMenuTheme.Length; i++)
            {
                SwipeMenuTheme[i].sprite = MenuThemeRed[i];
            }
        }
        else if (smenka == 1 || smenka == 0)
        {
            for (int i = 0; i < meshtheme.Length; i++)
            {
                meshtheme[i].material = materials[2];
            }
            for (int i = 0; i < SwipeMenuTheme.Length; i++)
            {
                SwipeMenuTheme[i].sprite = MenuthemeDefault[i];
            }
        }
    }



    public void SKA(int suka)
    {
        replayed = suka;
    }

    public void SmenochkaRed() 
    {
        smenka = 3;
    }
    public void SmenochkaOrange()
    {
        smenka = 2;
    }
    public void SmenochkaBlue()
    {
        smenka = 1;
    }
}
