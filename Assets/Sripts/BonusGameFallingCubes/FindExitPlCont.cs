using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindExitPlCont : MonoBehaviour
{

    private float speed = 10f;
    private Vector3 moveDirection;

    public  bool isjump;

    public void Start()
    {
        transform.GetComponent<CharacterController>(); 
    }

    private void Update()
    {
        moveDirection.y -= 30 * Time.deltaTime;
        var dir = moveDirection.normalized * speed;
        dir.y = -10;
        transform.GetComponent<CharacterController>().Move(dir * Time.deltaTime);
        float horizontal = Input.GetAxis("Horizontal");
        Vector3 directional = new Vector3(horizontal,0, 0);
        if (directional.magnitude >= 0.1f)
        {
            
            transform.GetComponent<CharacterController>().Move(directional * speed * Time.deltaTime);
        }

        if (isjump && Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 30f * Time.deltaTime, transform.position.z);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Grund"))
        {
            isjump = true;
        }   
    }

    private void OnTriggerExit(Collider collider)
    {
        isjump = false;
    }
}
