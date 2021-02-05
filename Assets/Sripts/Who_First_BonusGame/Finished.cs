using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finished : MonoBehaviour
{
    [SerializeField] private Other_Player_Controll _bots;
    [SerializeField] private Player_Controller _PlControll;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FINISH"))
        {
            _bots.enabled = false;
        }
    }

}
