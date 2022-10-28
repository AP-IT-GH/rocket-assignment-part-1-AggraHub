using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raket : MonoBehaviour
{
    public float Power;
    public float TorquePower;


    private Rigidbody rocketbody;
    private bool movingUp;
    private int rotateDir;

    void Start()
    {
        rocketbody = GetComponent<Rigidbody>();
        rocketbody.maxAngularVelocity = 10;
    }

    // Update input
    void Update()
    {
        movingUp = Input.GetKey(KeyCode.Space);
        rotateDir = 0;

        if (Input.GetKey(KeyCode.LeftArrow))
            rotateDir--;

        if (Input.GetKey(KeyCode.RightArrow))
            rotateDir++;
    }

    // Update physics
    void FixedUpdate()
    {
        if (movingUp)
            rocketbody.AddRelativeForce(Vector3.up * Power);

        // multiple by -1 to fix left/right
        rocketbody.AddRelativeTorque(new Vector3(0, 0, rotateDir * TorquePower * -1));
    }
}
