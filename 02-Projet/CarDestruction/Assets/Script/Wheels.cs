using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class Wheels : MonoBehaviour
{
    public WheelCollider fl;
    public WheelCollider fr;
    public WheelCollider bl;
    public WheelCollider br;

    
    public TextMeshProUGUI txtSpeed;
    public float torque;
    public static float speed;
    public float maxSpeed;
    public int brake;
    public float coefAccel = 30f;
    public float maxAngle = 50f;
    public bool frein;

    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0, -1f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(!Car.inCar)
        {
            return;
        }

        speed = GetComponent<Rigidbody>().velocity.magnitude * 1.5f;
        txtSpeed.text = Convert.ToString((int)speed);

        //accel
        bl.brakeTorque = 0;
        br.brakeTorque = 0;
        bl.motorTorque = Input.GetAxis("Vertical") * torque * coefAccel * Time.deltaTime;
        br.motorTorque = Input.GetAxis("Vertical") * torque * coefAccel * Time.deltaTime;
        fl.brakeTorque = 0;
        fr.brakeTorque = 0;
        fl.motorTorque = Input.GetAxis("Vertical") * torque * coefAccel * Time.deltaTime;
        fr.motorTorque = Input.GetAxis("Vertical") * torque * coefAccel * Time.deltaTime;

        //décelération
        if (Input.GetAxis("Vertical") == 0)
        {

            bl.motorTorque = 0;
            br.motorTorque = 0;
            bl.brakeTorque = brake * coefAccel * Time.deltaTime;
            br.brakeTorque = brake * coefAccel * Time.deltaTime;
            fl.motorTorque = 0;
            fr.motorTorque = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            bl.brakeTorque = Mathf.Infinity;
            br.brakeTorque = Mathf.Infinity;
        }

        //direction
        fl.steerAngle = Input.GetAxis("Horizontal") * maxAngle;
        fr.steerAngle = Input.GetAxis("Horizontal") * maxAngle;

    }
}
