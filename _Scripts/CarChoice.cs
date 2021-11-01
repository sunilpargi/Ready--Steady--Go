using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject yellowBody;
    public GameObject whiteBody;
    public GameObject blackBody;
    public GameObject blueBody;
    public GameObject redBody;
    public GameObject greenBody;
    public int carImport;

    void Awake()
    {
        if(GlobalCar.carType == 1)
        {
            yellowBody.SetActive(true);
           
        }

        if (GlobalCar.carType == 2)
        {
            whiteBody.SetActive(true);
        }

        if (GlobalCar.carType == 3)
        {
            blackBody.SetActive(true);
        }

        if (GlobalCar.carType == 4)
        {
            blueBody.SetActive(true);

        }

        if (GlobalCar.carType == 5)
        {
            redBody.SetActive(true);
        }

        if (GlobalCar.carType == 6)
        {
            greenBody.SetActive(true);
        }
    }
}
