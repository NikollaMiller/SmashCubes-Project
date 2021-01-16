using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    private Vector3 LocalKaScaleLa;
    
    public void Start()
    {
        LocalKaScaleLa = transform.localScale;
    }

    
    public void Update()
    {
        LocalKaScaleLa.z = CubesMakeDamage.aga;
        transform.localScale = LocalKaScaleLa;
    }
}
