using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BonusProverka : MonoBehaviour
{
    public LayerMask maskich;

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            Ray Rayca = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(Rayca,out hit,10,maskich)) 
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
