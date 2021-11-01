using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LapTimeManager : MonoBehaviour
{
    public static int minuteCount;
    public static int secondCount;
    public static float miliCount;
    public static string miliDisplay;

    public GameObject minuteBOx;
    public GameObject secondBOx;
    public GameObject miliBOx;

    public static float rawTime;
    public  bool isRaceFinished;


    private void Awake()
    {
        isRaceFinished = true;
    }
    void Update()
    {
        if (!isRaceFinished)
        {
            miliCount += Time.deltaTime * 10;
            rawTime += Time.deltaTime;
            miliDisplay = miliCount.ToString("F0");
            miliBOx.GetComponent<Text>().text = "" + miliDisplay;

            if (miliCount >= 10)
            {
                miliCount = 0;
                secondCount += 1;
            }

            if (secondCount <= 9)
            {
                secondBOx.GetComponent<Text>().text = "0" + secondCount + ":";
            }
            else
            {
                secondBOx.GetComponent<Text>().text = "" + secondCount + ":";
            }

            if (secondCount >= 60)
            {
                secondCount = 0;
                minuteCount += 1;
            }

            if (minuteCount <= 9)
            {
                minuteBOx.GetComponent<Text>().text = "0" + minuteCount + ":";
            }
            else
            {
                minuteBOx.GetComponent<Text>().text = "" + minuteCount + ":";
            }
        }

       

    }
}
