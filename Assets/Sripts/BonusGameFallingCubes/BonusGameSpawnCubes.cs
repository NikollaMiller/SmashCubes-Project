using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGameSpawnCubes : MonoBehaviour
{
    [SerializeField] private GameObject fali;

    private float second = .5f;
    private float NextSpawnTime;

    private void Update()
    {
        if (Time.time > NextSpawnTime)
        {
            NextSpawnTime = Time.time + second;
            for (int i = 0; i < 1; i++)
            {
                var cell = Instantiate(fali, transform.position, Quaternion.identity);
                cell.transform.localPosition = new Vector3(Random.Range(transform.localPosition.x,2.5f), transform.localPosition.y, transform.localPosition.z);
            }
        }
    }
}
