using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody RBRocket;
    public float maxSpeedJump = 0.01f;
    public float rotationSpeed = 10;
    private Vector3 targetVelocity;
    private Vector3 HorizontalTorque;
    // Start is called before the first frame update
    void Start()
    {
        HorizontalTorque = new Vector3();
        HorizontalTorque.x = rotationSpeed;
        RBRocket = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputJump = Input.GetAxis("Jump");
        float inputHorizontal = Input.GetAxis("Horizontal");
        if (inputJump != 0)
        {
            targetVelocity.y = inputJump * maxSpeedJump;
            gameObject.transform.Translate(targetVelocity);
        }
        if (inputHorizontal != 0)
        {
            if (Input.GetKey("left"))
            {
                RBRocket.AddRelativeTorque(-HorizontalTorque, ForceMode.Force);
            }
            if (Input.GetKey("right"))
            {
                RBRocket.AddRelativeTorque(HorizontalTorque, ForceMode.Force);
            }
        }
    }
}
