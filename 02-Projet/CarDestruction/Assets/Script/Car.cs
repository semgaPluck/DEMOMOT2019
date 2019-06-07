using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    bool carSides;

    [SerializeField]
    Text TextToEnterInCar;

    [SerializeField]
    GameObject cameraCar;
    [SerializeField]
    GameObject cameraPlayer;
    [SerializeField]
    GameObject Player;

    
    PlayerWalk ScriptWalk;
    

    // Start is called before the first frame update
    void Start()
    {
        carSides = true;
        cameraCar.SetActive(false);

        ScriptWalk = GetComponent<PlayerWalk>();
        ScriptWalk.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && TextToEnterInCar.text == "Press Space")
        {
            TextToEnterInCar.text = "";
            EnterInCar();
        }
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
        cameraPlayer.SetActive(false);
        cameraCar.SetActive(true);
        Player.SetActive(false);

        ScriptWalk.enabled = true;
    }
}