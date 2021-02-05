using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody _player;

    private float speed;

    private bool _isGround;
    private bool _clickJump;
    private void Start()
    {
        _player = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _player.velocity = new Vector3(_player.velocity.x, _player.velocity.y,speed);

        if (_clickJump && _isGround)
        {
            _player.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }

    public void JumpButton() 
    {
        if (_isGround)
        {
            _clickJump = true;
        }
        else 
        {
            _clickJump = false;
        }
    }

    public void RunDown() 
    {
       speed = 5;
    }

    public void RunUp() 
    {
        speed = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Grund")) 
        {
            _isGround = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        _isGround = false;
        _clickJump = false;
    }
}
