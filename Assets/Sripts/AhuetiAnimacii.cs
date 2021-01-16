using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AhuetiAnimacii : MonoBehaviour
{
    public Transform tochka;
    private float speed = 8f;
    private bool datronul;
    public Animator zvezda;

    public void Update()
    {
        if (datronul)
        {
            transform.position = Vector2.MoveTowards(transform.position, tochka.position, speed * Time.deltaTime);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cubs")
        {
            zvezda.SetInteger("Stars",1);
            datronul = true;
        }
    }
}
