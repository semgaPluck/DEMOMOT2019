using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Controller : MonoBehaviour
{
    [Header("Buildings")]
    [SerializeField] private GameObject[] bats;
    [SerializeField] private GameObject spawnPoints;
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI txtTimer;

    private float timeLeft;

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

        timeLeft = 60;
    }

    void Update()
    {
        if(Car.inCar)
        {
            Timer();
            if (timeLeft < 0)
            {
                GameOver();
            }
        }
    }

    void Timer()
    {
        timeLeft -= Time.deltaTime;
        txtTimer.text = Convert.ToString((int)timeLeft);
    }

    void GameOver()
    {

    }

}
