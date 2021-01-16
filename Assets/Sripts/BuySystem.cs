using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class BuySystem : MonoBehaviour
{
    [SerializeField] private Text MAGAZINE;
    [SerializeField] private Text YES;
    [SerializeField] private Text NO;
    [SerializeField] private Text[] buyBtn;
    [SerializeField] private Text WHATYOUBUY;
    [SerializeField] private Text wannabuy;
    [SerializeField] private Animator Store;
    [SerializeField] private Animator podStore;
    [SerializeField] private GameObject Storek;
    [SerializeField] private GameObject podStorek;
    [SerializeField] private Animator ShopBtn;
    [SerializeField] private GameObject ShopBtnk;
     public GameObject NotMoney;
     public Text nouMoney;

    public Transform spawnpos;

    private int selected;

    private void Update()
    {

        if (Application.systemLanguage == SystemLanguage.Russian)
        {
            nouMoney.text = "НЕ Хватает звезд";
            MAGAZINE.text = "МАГАЗИН";
            YES.text = "ДА";
            NO.text = "НЕТ";
            wannabuy.text = "КУПИТЬ ПОДСКАЗКИ ДЛЯ ВСЕХ УРОВНЕЙ";
            for (int i = 0; i < buyBtn.Length; i++)
            {
                buyBtn[i].text = "КУПИТЬ";
            }
        }
        else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
        {
            nouMoney.text = "НЕ Хватает звезд";
            YES.text = "是";
            NO.text = "没有";
            MAGAZINE.text = "得分";
            wannabuy.text = "购买所有级别的提示";
            for (int i = 0; i < buyBtn.Length; i++)
            {
                buyBtn[i].text = "购买";
            }
        }
        else if (Application.systemLanguage == SystemLanguage.Korean)
        {
            nouMoney.text = "НЕ Хватает звезд";
            YES.text = "예";
            NO.text = "아니";
            wannabuy.text = "모든 레벨에 대한 팁 구매";
            MAGAZINE.text = "점수";
            for (int i = 0; i < buyBtn.Length; i++)
            {
                buyBtn[i].text = "구입";
            }
        }
        else if (Application.systemLanguage == SystemLanguage.German)
        {
            nouMoney.text = "НЕ Хватает звезд";
            YES.text = "JA";
            NO.text = "Nein";
            wannabuy.text = "KAUFEN SIE TIPPS FÜR ALLE STUFEN";
            MAGAZINE.text = "ERGEBNIS";
            for (int i = 0; i < buyBtn.Length; i++)
            {
                buyBtn[i].text = "KAUFEN";
            }
        }
        else
        {
            nouMoney.text = "Have no money";
            YES.text = "YES";
            NO.text = "NO";
            wannabuy.text = "BUY TIPS FOR ALL LEVELS";
            MAGAZINE.text = "STORE";
            for (int i = 0; i < buyBtn.Length; i++)
            {
                buyBtn[i].text = "BUY";
            }
        }

        if (selected == 1)
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                WHATYOUBUY.text = "КУПИТЬ 5 ПЛАТФОРМ ЗА 10 звезд ? ";
            }
            else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
            {
                WHATYOUBUY.text = "购买5个10颗星的平台？";
            }
            else if (Application.systemLanguage == SystemLanguage.Korean)
            {
                WHATYOUBUY.text = "별 10 개에 5 개의 플랫폼을 구입 하시겠습니까?";
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                WHATYOUBUY.text = "5 PLATTFORMEN FÜR 10 Sterne KAUFEN?";
            }
            else
            {
                WHATYOUBUY.text = "BUY 5 PLATFORMS FOR 10 STARS?";
            }
        }
        else if (selected == 2)
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                WHATYOUBUY.text = "КУПИТЬ 5 ТРЕУГОЛЬНИКОВ ЗА 10 звезд?";
            }
            else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
            {
                WHATYOUBUY.text = "买5颗三角形的10颗星？";
            }
            else if (Application.systemLanguage == SystemLanguage.Korean)
            {
                WHATYOUBUY.text = "별 10 개에 삼각형 5 개를 구입 하시겠습니까?";
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                WHATYOUBUY.text = "5 DREIECKE FÜR 10 STERNE KAUFEN?";
            }
            else
            {
                WHATYOUBUY.text = "BUY 5 TRIANGLES FOR 10 STARS?";
            }
        }
        else if (selected == 3)
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                WHATYOUBUY.text = "КУПИТЬ 5 СФЕР ЗА 10 звезд?";
            }
            else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
            {
                WHATYOUBUY.text = "购买5颗球以获得10颗星？";
            }
            else if (Application.systemLanguage == SystemLanguage.Korean)
            {
                WHATYOUBUY.text = "별 10 개에 구 5 개를 구입 하시겠습니까?";
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                WHATYOUBUY.text = "5 KUGELN FÜR 10 STERNE KAUFEN?";
            }
            else
            {
                WHATYOUBUY.text = "BUY 5 SPHRES FOR 10 STARS?";
            }
        }
        else if (selected == 4)
        {
            if (Application.systemLanguage == SystemLanguage.Russian)
            {
                WHATYOUBUY.text = "КУПИТЬ БЕСКОНЕЧНЫЕ ПОДСКАЗКИ ЗА 150  зВЕЗД?";
            }
            else if (Application.systemLanguage == SystemLanguage.ChineseSimplified)
            {
                WHATYOUBUY.text = "购买150星的无穷提示？";
            }
            else if (Application.systemLanguage == SystemLanguage.Korean)
            {
                WHATYOUBUY.text = "별 150 개에 대한 끝없는 팁을 구입 하시겠습니까?";
            }
            else if (Application.systemLanguage == SystemLanguage.German)
            {
                WHATYOUBUY.text = "ENDLOSE TIPPS FÜR 150 STERNE KAUFEN?";
            }
            else
            {
                WHATYOUBUY.text = "BUY ENDLESS TIPS FOR 150 STARS?";
            }
        }
    }

    public void BuykaYes() 
    {
        if (selected == 1)
        {
            if (StarSystem.AllStars >= 10)
            {
                 StarSystem.AllStars -= 10;
                 spawn.PlatformCH += 5;
            }
            else
            {
                var cell = Instantiate(NotMoney, spawnpos);
                NotMoney.SetActive(true);
                cell.transform.localPosition = new Vector3(spawnpos.transform.localPosition.x, spawnpos.transform.localPosition.y, spawnpos.transform.localPosition.z);
                Invoke("DestroyMoney", 0.7f);
            }

        }
        else if (selected == 2)
        {
            if (StarSystem.AllStars >= 10)
            {
                StarSystem.AllStars -= 10;
                spawn.TriangleCH += 5;
            }
            else
            {
                var cell = Instantiate(NotMoney, spawnpos);
                NotMoney.SetActive(true);
                cell.transform.localPosition = new Vector3(spawnpos.transform.localPosition.x, spawnpos.transform.localPosition.y, spawnpos.transform.localPosition.z);
                Invoke("DestroyMoney", 0.7f);
            }
        }
        else if (selected == 3)
        {
                if (StarSystem.AllStars >= 10)
                {
                    StarSystem.AllStars -= 10;
                    spawn.CircleCH += 5;
                }
            else
            {
                var cell = Instantiate(NotMoney, spawnpos);
                NotMoney.SetActive(true);
                cell.transform.localPosition = new Vector3(spawnpos.transform.localPosition.x, spawnpos.transform.localPosition.y, spawnpos.transform.localPosition.z);
                Invoke("DestroyMoney", 0.7f);
            }
        }
        else if (selected == 4)
        {
                if (StarSystem.AllStars >= 150)
                {
                    StarSystem.AllStars -= 150;
                }
            else
            {
                var cell = Instantiate(NotMoney, spawnpos);
                NotMoney.SetActive(true);
                cell.transform.localPosition = new Vector3(spawnpos.transform.localPosition.x, spawnpos.transform.localPosition.y, spawnpos.transform.localPosition.z);
                Invoke("DestroyMoney", 0.7f);
            }
        }
    }

    private void DestroyMoney()
    {
        NotMoney.SetActive(false);
        nouMoney.text = "";
        
    }
    public void TraingleBuySelected(int opinion)
    {
        selected = opinion;
        Debug.Log(selected);
    }

    public void ClosePodBuySelected()
    {
        podStore.SetInteger("PodStore", 1);
        Invoke("Close", 1);
    }

    public void CloseMainStore()
    {
        Store.SetInteger("Store", 1);
        Invoke("closeMAin", 1);
        Invoke("OpenBtn",1f);
    }

    public void OpenMainStore() 
    {
        ShopBtn.SetInteger("ShopBtnki",1);
        Invoke("CloseBtn",1);
        Invoke("OpenikMainStore", 1);
    }

    private void CloseBtn() 
    {
        ShopBtnk.SetActive(false);
    }

    private void closeMAin()
    {
        Storek.SetActive(false);
        ShopBtn.SetInteger("ShopBtnki", 0);
    }

    private void OpenikMainStore()
    {
        Storek.SetActive(true);
    }

    private void Close() 
    {
        podStorek.SetActive(false);
    }

    private void OpenBtn() 
    {
        ShopBtnk.SetActive(true);
    }
}
