using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Wheels : MonoBehaviour
{
    public WheelCollider fl;
    public WheelCollider fr;
    public WheelCollider bl;
    public WheelCollider br;

    public Text txtSpeed;
    public float torque;
    public float speed;
    public float maxSpeed;
    public int brake;
    public float coefAccel = 30f;
    public float maxAngle = 50f;
    public bool frein;

    void Start()
    {
        GetComponent<Rigidbody>().centerOfMass = new Vector3(0, -2, -1);
    }

    // Update is called once per frame
    void Update()
    {

        speed = GetComponent<Rigidbody>().velocity.magnitude * 3.6f;
        txtSpeed.text = "Speed :" + (int)speed;

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

        //direction
        fl.steerAngle = Input.GetAxis("Horizontal") * maxAngle;
        fr.steerAngle = Input.GetAxis("Horizontal") * maxAngle;

    }
}
