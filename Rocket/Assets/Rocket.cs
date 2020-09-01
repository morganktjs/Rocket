using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    Rigidbody RBRocket;
    // Start is called before the first frame update
    void Start()
    {
        RBRocket = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputJump = Input.GetAxis("Jump");
        if (inputJump != 0)
        {
            
        }
    }
}
