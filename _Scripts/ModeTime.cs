using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class ModeTime : MonoBehaviour
{

    public GameObject aiCar;

    public static bool isTimeMOde;

    void Update()
    {

        if (ModeSelect.raceMode == 2)
        {
            isTimeMOde = true;
            aiCar.SetActive(false);
        }


    }
}
