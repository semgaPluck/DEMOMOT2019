using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalk : MonoBehaviour
{

    [SerializeField]
    Rigidbody rbPlayer;

    [SerializeField]
    float speed;


    private float _X = 0;
    private float _Z = 0;

    public playerWalk(float X, float Z)
    {
        float _X = X;
        float _Z = Z;
    }

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        _X = Input.GetAxisRaw("Horizontal");
        _Z = Input.GetAxisRaw("Vertical");

        Vector2 velocity = new Vector2(_X,_Z);

        this.walk(velocity);


    }

    void walk(Vector2 velocity)
    {
        rbPlayer.AddForce(velocity, speed)
    }
}
