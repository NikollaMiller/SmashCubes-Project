using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindExitMainCubeControll : MonoBehaviour
{
    private float speed = 4;
    private Rigidbody cube;
    private Transform cubes;

    private void Start()
    {
        cube = this.GetComponent<Rigidbody>();
        cubes = this.GetComponent<Transform>();
    }

    private void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed;

        cube.velocity = new Vector2(move,cube.velocity.y);

      //  cubes.Rotate(Vector3.up * speed * Time.deltaTime);
    }

}
