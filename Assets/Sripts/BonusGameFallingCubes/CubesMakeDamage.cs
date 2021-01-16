using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesMakeDamage : MonoBehaviour
{
    public static float aga = 1.836328f;
    [SerializeField] private Material[] redka;
    [SerializeField] private MeshRenderer redn;

    private void Start()
    {
        aga = 1.836328f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Whus")
        {
            Debug.Log("Dealing damage");
            aga -= 0.2f;
            redn.material = redka[0];
            transform.position = new Vector3(transform.position.x, transform.position.y + 15f * Time.deltaTime,transform.position.z); 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Invoke("ColorChange",0.3f);
    }

    private void ColorChange() 
    {
        redn.material = redka[1];
    }
}
