using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float throtle;
    public float steer;

    public bool isBreak;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        throtle = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            isBreak = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isBreak = false;
        }
        
    }
}
