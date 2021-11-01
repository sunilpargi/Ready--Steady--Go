using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    public static int carType;
   
    public static GlobalCar instance;

    

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public void YellowCar()
    {
        carType = 1;
       
    }

    public void WhiteCar()
    {
        carType = 2;
        
    }

    public void BlackCar()
    {
        carType = 3;
       
    }

    public void BlueCar()
    {
        carType = 4;
       
    }
    public void RedCar()
    {
        carType = 5;
       
    }

    public void GreenCar()
    {
        carType = 6;
       
    }

    
}
