using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionCol : MonoBehaviour
{
    public int colSpeed;
    public int batValue = 0;

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