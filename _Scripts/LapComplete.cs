using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject minuteDisplay;
    public GameObject secondDisplay;
    public GameObject miliDisplay;

    //public GameObject lapCompleteTrig;
    //public GameObject highCompleteTrig;

   // public GameObject lapTimerBOx;

    public GameObject lapCountertext;
    public int lapsDone = 0;

    public float rawTime;

   // public GameObject finishLap;

    public GameObject finalLapComplete;
    public LapTimeManager lapTImeManager;

    public GameObject lapLabelText;

  
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            finalLapComplete.GetComponent<LapComplete>().lapsDone++;

            if (finalLapComplete.GetComponent<LapComplete>().lapsDone == 1)
            {

                lapLabelText.GetComponent<Text>().text = "1st Lap Is Completed";
                lapLabelText.GetComponent<Animator>().SetTrigger("FadeInOut");


            }
            if (finalLapComplete.GetComponent<LapComplete>().lapsDone == 2)
            {
           
                lapLabelText.GetComponent<Text>().text = "2nd Lap Is Completed";
                lapLabelText.GetComponent<Animator>().SetTrigger("FadeInOut");
            }


            if (finalLapComplete.GetComponent<LapComplete>().lapsDone == 3)
            {
                
                //lapLabel.GetComponent<Text>().text = "Final lap is completed";
                //lapLabel.GetComponent<Animator>().Play("FadeInOut");

                //// finishLap.SetActive(true);
                lapTImeManager.isRaceFinished = true;
            }

            rawTime = PlayerPrefs.GetFloat("RawTime");

            if (LapTimeManager.rawTime <= rawTime) // if high score
            {
                if (LapTimeManager.secondCount <= 9)
                {
                    secondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secondCount + ":";
                }
                else
                {
                    secondDisplay.GetComponent<Text>().text = "" + LapTimeManager.secondCount + ":";
                }

                if (LapTimeManager.minuteCount <= 9)
                {
                    minuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ":";
                }
                else
                {
                    minuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.minuteCount + ":";
                }

                miliDisplay.GetComponent<Text>().text = "" + LapTimeManager.miliCount;

            }
            PlayerPrefs.SetInt("MinSave", LapTimeManager.minuteCount);
            PlayerPrefs.SetInt("SecSave", LapTimeManager.secondCount);
            PlayerPrefs.SetFloat("MilliSave", LapTimeManager.miliCount);
            PlayerPrefs.SetFloat("RawTime", LapTimeManager.rawTime);

            LapTimeManager.minuteCount = 0;
            LapTimeManager.secondCount = 0;
            LapTimeManager.miliCount = 0;
            LapTimeManager.rawTime = 0;

            lapCountertext.GetComponent<Text>().text = "" + finalLapComplete.GetComponent<LapComplete>().lapsDone;

            //highCompleteTrig.SetActive(true);
            //lapCompleteTrig.SetActive(false);


        }

    }

   
}
