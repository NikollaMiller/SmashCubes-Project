using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawn : MonoBehaviour
{
    [SerializeField] private GameObject fali;

    private float second = .4f;
    private float NextSpawnTime;

    Vector2 screenUnits;

    private void Start()
    {
        screenUnits = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    private void Update()
    {
        if (Time.time > NextSpawnTime)
        {
            NextSpawnTime = Time.time + second;
            var cell = Instantiate(fali, transform.position, Quaternion.identity);
            cell.transform.localPosition = new Vector3(Random.Range(transform.localPosition.x, 2.5f), transform.localPosition.y, transform.localPosition.z);

        }
    }
}
