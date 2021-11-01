using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(InputManager))]
public class CarController : MonoBehaviour
{
    public Rigidbody rb;

    public InputManager inputManager;
    public List<WheelCollider> throtleWheels;
    public List<GameObject> steerWheels;
    public List<GameObject> wheelsMeshes;

    public float strengthCoeffiecient = 20000f;
    public float maxTurn = 20f;
    public float breakStrength = 20f;

    private void FixedUpdate()
    {
        foreach(WheelCollider wheel in throtleWheels)
        {
            if (inputManager.isBreak)
            {

                wheel.motorTorque = 0;
                wheel.brakeTorque = breakStrength * Time.deltaTime;
            }

            else
            {
                wheel.motorTorque = inputManager.throtle * strengthCoeffiecient * Time.deltaTime;
                wheel.brakeTorque = 0;

            }
        }

        foreach (GameObject wheel in steerWheels)
        {
            wheel.GetComponent<WheelCollider>().steerAngle = inputManager.steer * maxTurn ;
            wheel.transform.localEulerAngles = new Vector3(0f, inputManager.steer * maxTurn, 0f);
        }

        foreach(GameObject wheelMash in wheelsMeshes)
        {
            transform.Rotate(rb.velocity.magnitude * (transform.InverseTransformDirection(rb.velocity).z >= 0 ? 1 : -1) / (2 * Mathf.PI * 0.33f), 0f, 0f);
        }
    }

}
