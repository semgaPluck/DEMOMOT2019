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
    public float coefAccel = 10f;

    // Update is called once per frame
    void Update()
    {

        speed = GetComponent<Rigidbody>().velocity.magnitude * 3.6f;
        txtSpeed.text = "Speed :" + (int)speed;

        //accel
        if(Input.GetKey(KeyCode.UpArrow))
        {
            bl.brakeTorque = 0;
            br.brakeTorque = 0;
            bl.motorTorque = Input.GetAxis("Vertical") * torque * coefAccel * Time.deltaTime * 100;
            br.motorTorque = Input.GetAxis("Vertical") * torque * coefAccel * Time.deltaTime * 100;
        }

        //décelération
        if (!Input.GetKey(KeyCode.UpArrow))
        {
            bl.motorTorque = 0;
            br.motorTorque = 0;
            bl.brakeTorque = brake * coefAccel * Time.deltaTime;
            br.brakeTorque = brake * coefAccel * Time.deltaTime;
        }

    }
}
