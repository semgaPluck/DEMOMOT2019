using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Controller : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject[] bats;
    [SerializeField] private GameObject spawnPoints;

    System.Random rnd = new System.Random();

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = 0; i < spawnPoints.transform.childCount;i++)
        {
            if(rnd.Next(0,10) != 0)
            {
                Instantiate(bats[rnd.Next(0, bats.Length)], spawnPoints.transform.GetChild(i).position, Quaternion.identity);
            }
        }
    }

}
