using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    Rigidbody shipRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        shipRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            shipRigidBody.AddForce(Vector3.forward, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.S))
        {
            shipRigidBody.AddForce(Vector3.back, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.E))
        {
            shipRigidBody.AddForce(Vector3.up, ForceMode.Acceleration);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            shipRigidBody.AddForce(Vector3.down, ForceMode.Acceleration);
        }

    }
}
