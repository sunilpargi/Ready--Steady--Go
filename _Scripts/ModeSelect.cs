using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeSelect : MonoBehaviour
{
    public static int raceMode;
    public AudioSource uiTouchSound;

    public void RaceMode()
    {
        uiTouchSound.Play();
        raceMode = 0;
    }
    public void ScoreMode()
    {
        uiTouchSound.Play();
        raceMode = 1;
    }

    public void TimeMode()
    {
        uiTouchSound.Play();

        raceMode = 2;
    }

  
}
