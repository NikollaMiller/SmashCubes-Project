using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    [SerializeField]private Other_Player_Controll _botControll;
    [SerializeField] private Player_Controller _playerCont;
    [SerializeField] private PlaceTreckerScript plced;

    [SerializeField] private GameObject _startPanel;
    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private Text _HelloShower;
    [SerializeField] private Text _TimeShower;
    [SerializeField] private Text _positionShow;

    private float _second;
    private bool _gameStartBtnPressed;

    private void Start()
    {
        _second = 5;
        _botControll.enabled = false;
        _playerCont.enabled = false;
    }

    private void Update()
    {
        _HelloShower.text = "Hello";
        _positionShow.text = $"{plced.place}";

        if (_gameStartBtnPressed) 
        {
            _second -= Time.deltaTime;
            int x = Convert.ToInt32(_second);
            _TimeShower.text = $"{x}";

            if (_second < 0) 
            {
                _second = 0;
                _TimeShower.text = "";
                _botControll.enabled = true;
                _playerCont.enabled = true;
            }
        }
    }

    public void StartGame() 
    {
        _startPanel.SetActive(false);
        _gamePanel.SetActive(true);
        _gameStartBtnPressed = true;
    }

}
