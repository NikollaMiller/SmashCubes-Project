using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _trap;
    [SerializeField] private Transform _start_SpawnPos;

    [SerializeField] private float Width;

    private void Start()
    {
        var cell = Instantiate(_trap,_start_SpawnPos);
        cell.transform.localPosition = new Vector3(0, 0,Random.Range(cell.transform.localPosition.z,Width));
    }

}
