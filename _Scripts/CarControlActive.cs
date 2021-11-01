using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControlActive : MonoBehaviour
{
    public GameObject carController ,aiController;
    void Update()
    {
        carController.GetComponent<CarController>().enabled = true;

        aiController.GetComponent<CarController>().enabled = true;
        Debug.Log("hello");
        Debug.Log(carController.GetComponent<CarController>().enabled);
       
    }

  
}
