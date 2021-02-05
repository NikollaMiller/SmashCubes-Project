using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Other_Player_Controll : MonoBehaviour
{
    [SerializeField]private Rigidbody[] _player;

    private float speed = 2.5f;

    private void Update()
    {
        float move = Input.GetAxis("Vertical") + speed;

        for (int i = 0; i < _player.Length; i++)
        {
             _player[i].velocity = new Vector3(_player[i].velocity.x, _player[i].velocity.y, move);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FINISH")) 
        {

        }
    }
}
