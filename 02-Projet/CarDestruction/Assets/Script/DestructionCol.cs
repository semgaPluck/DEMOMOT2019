using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionCol : MonoBehaviour
{
    
    
    public int colSpeed;
    public int batValue = 0;

    private string gameObjectName;

    // Start is called before the first frame update
    void Start()
    {
        //gameObjectName = gameObject.name;
    }

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(gameObjectName);

    }

    void OnTriggerStay(Collider car)
    {
        if (car.gameObject.tag != "Car")
        {
            return;
        }

        if (Wheels.speed > colSpeed)
        {
            AddPoints();
            Destroy(gameObject);
        }
    }

    void AddPoints()
    {
        Car.score += batValue;
    }

}
