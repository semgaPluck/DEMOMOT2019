using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Car : MonoBehaviour
{
    

    [SerializeField]
    Text TextToEnterInCar;

    [SerializeField]
    GameObject cameraCar;
    [SerializeField] GameObject cameraPlayer;
    [SerializeField] GameObject Player;
    [SerializeField] private TextMeshProUGUI txtScore;

    PlayerWalk ScriptWalk;

    public static bool inCar = false;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        inCar = false;
        cameraPlayer.SetActive(true);
        cameraCar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("SCORE: " + score);

        if (Input.GetKey(KeyCode.Space) && TextToEnterInCar.text == "Press Space")
        {
            TextToEnterInCar.text = "";
            EnterInCar();
        }

        if(Input.GetKey(KeyCode.R))
        {
           
            transform.Translate(0, 3720.38f, 0);

        }

        txtScore.text = Convert.ToString(score);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag != "Player")
        {
            return;
        }

        TextToEnterInCar.text = "Press Space";
    }

    void OnTriggerExit(Collider player)
    {
        TextToEnterInCar.text = " ";
    }

    void EnterInCar()
    {
        inCar = true;

        cameraPlayer.SetActive(false);
        cameraCar.SetActive(true);
        Player.SetActive(false);

       
    }
}