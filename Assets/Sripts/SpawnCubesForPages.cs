using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnCubesForPages : MonoBehaviour
{
    public GameObject[] cbe;
    public GameObject Levels;
    public Animator LevelsClosed;
    public Animator OptionsClosed;
    public GameObject Menu;
    public GameObject Options;
    public Transform pos;
    public SpawnCubesForPages Spawner;
    public KilCubes opyat;
    public float Width;
    public Spawner menuSpawner;
    public GameObject MenuStarcount;
    public GameObject MenuPlat;
    public static int agahochu;
    public GameObject ShopBtn;
    public Animator ShopikBtnchik;
    public GameObject BonusGameBtn;
    public Animator BonusGameBtnAnim;
    public bool no;

    public void Start()
    {
        Spawner = GetComponent<SpawnCubesForPages>();
    }

    void Update()
    {
        for (int i = 0; i < cbe.Length; i++)
        {
            var cell = Instantiate(cbe[i], pos);
            cell.transform.localPosition = new Vector3(Random.Range(0, Width), 0, 0);
        }

    }

    public void FallActive() 
    {
        menuSpawner.enabled = true;
    }

    public void FallDeactive() 
    {
        menuSpawner.enabled = false;
    }

    public void ToLevels() 
    {
        ShopikBtnchik.SetInteger("ShopBtnki", 1);
        BonusGameBtnAnim.SetInteger("ShopBtnki", 1);
        LevelsClosed.SetInteger("CloseLevel", 0);
        opyat.enabled = false;
        Spawner.enabled = true;
        Invoke("Open",1.3f);
        MenuPlat.SetActive(false); 
        menuSpawner.enabled = false;
    }

    public void CloseLevels() 
    {
        ShopikBtnchik.SetInteger("ShopBtnki", 0);
        BonusGameBtnAnim.SetInteger("ShopBtnki", 0);
        LevelsClosed.SetInteger("CloseLevel", 1);
        opyat.enabled = false;
        menuSpawner.enabled = true;
        Spawner.enabled = true;
        Invoke("Close", 1.8f);
    }

    public void Open() 
    {
        BonusGameBtn.SetActive(false);
        opyat.enabled = true;
        Spawner.enabled = false;
        Levels.SetActive(true);
        ShopBtn.SetActive(false);
        menuSpawner.enabled = true;
    }

    public void Close() 
    {
        ShopBtn.SetActive(true);
        Levels.SetActive(false);
        BonusGameBtn.SetActive(true);
        MenuStarcount.SetActive(true);
        opyat.enabled = true;
        Spawner.enabled = false;
        MenuPlat.SetActive(true);
        menuSpawner.enabled = true;
        Menu.SetActive(true);
    }

    public void ToOptions() 
    {
        ShopikBtnchik.SetInteger("ShopBtnki",1);
        BonusGameBtnAnim.SetInteger("ShopBtnki", 1);
        OptionsClosed.SetInteger("closeOptions",0);
        Spawner.enabled = true;
        Invoke("OptionsOpen", 1.3f);
        MenuPlat.SetActive(false);
        menuSpawner.enabled = false;
    }

    public void OptionsOpen() 
    {
        ShopBtn.SetActive(false);
        BonusGameBtn.SetActive(false);
        menuSpawner.enabled = true;
        Spawner.enabled = false;
        Options.SetActive(true);
    }

    public void LeaveFromOpt() 
    {
        BonusGameBtnAnim.SetInteger("ShopBtnki", 0);
        ShopikBtnchik.SetInteger("ShopBtnki", 0);
        OptionsClosed.SetInteger("closeOptions", 1);
        menuSpawner.enabled = false;
        Spawner.enabled = true;
        Invoke("CloseOpt", 1.8f);
    }

    public void CloseOpt() 
    {
        BonusGameBtn.SetActive(true);
        ShopBtn.SetActive(true);
        Options.SetActive(false);
        Spawner.enabled = false;
        MenuPlat.SetActive(true);
        MenuStarcount.SetActive(true);
        menuSpawner.enabled = true;
        Menu.SetActive(true);
    }

    public void Play()
    {
        BonusGameBtnAnim.SetInteger("ShopBtnki", 1);
        ShopikBtnchik.SetInteger("ShopBtnki", 1);
        PlayerPrefs.SetInt("Selected", ReplayScript.SelectReplayLevel);
        ReplayScript.SelectReplayLevel = 0;
        menuSpawner.enabled = false;
        MenuPlat.SetActive(false);
        Invoke("PlayFallCubes",0.8f);
        Invoke("PlayMoution",2.1f);
        agahochu = 1;
    }
    public void PlayFallCubes() 
    {
        Spawner.enabled = true;
    }
    public void PlayMoution() 
    {
       SceneManager.LoadScene("1");
    }
}
