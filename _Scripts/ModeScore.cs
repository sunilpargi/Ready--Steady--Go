using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeScore : MonoBehaviour
{
    public GameObject scoreMode;
    public GameObject TimeMode;
    public GameObject aiCar;

    
   

    void Awake()
    {

        if (ModeSelect.raceMode == 0) //Race
        {
            scoreMode.SetActive(false);
            TimeMode.SetActive(true);
            aiCar.SetActive(true);
        } 

        if (ModeSelect.raceMode == 1) //Score
        {
            scoreMode.SetActive(true);
            TimeMode.SetActive(false);
            aiCar.SetActive(false);
        }

        if (ModeSelect.raceMode == 2) // time
        {
            scoreMode.SetActive(false);
            TimeMode.SetActive(true);
            aiCar.SetActive(false);
        }



    }


}
