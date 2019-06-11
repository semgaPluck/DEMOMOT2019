using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
  
    public float speed;

  
    public float rotateSpeed; 

    private float _X = 0;
    private float _Z = 0;
    private float _Y = 0;
    // Update is called once per frame
    void Update()
    {
        _X = Input.GetAxisRaw("Horizontal");
        _Y = Input.GetAxisRaw("Rotate");
        _Z = Input.GetAxisRaw("Vertical");

        Vector3 veloc = new Vector3(_Y, 0 , _Z);

        transform.Translate(veloc * speed * Time.deltaTime);
        

        transform.Rotate(0, _X * rotateSpeed, 0);
    }
}
