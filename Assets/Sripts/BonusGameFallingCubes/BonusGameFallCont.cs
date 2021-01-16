using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGameFallCont : MonoBehaviour
{
    private float speed = 7;

    private Vector3 stratpos;

    private float targetPos;

    private void Start()
    {
        Screen.autorotateToLandscapeLeft = Screen.autorotateToLandscapeRight = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { stratpos = Camera.main.ScreenToWorldPoint(Input.mousePosition); }
        else if (Input.GetMouseButton(0)) 
        {
            float pos = Camera.main.ScreenToWorldPoint(Input.mousePosition).x  - stratpos.x;
            targetPos = Mathf.Clamp(transform.position.x + pos, -2.14f, 2.11f);
        }
        transform.position = new Vector3(Mathf.Lerp(transform.position.x,targetPos,speed * Time.deltaTime),transform.position.y,transform.position.z);
    }
}
