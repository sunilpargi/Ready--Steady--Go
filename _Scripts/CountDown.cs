using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject countDown;
    public AudioSource getReady;
    public AudioSource goAudio;
    public GameObject lapTimer;
   // public CarActive carController;
    public AudioSource levelMusic;
    public LapTimeManager lapTimeManager;

    public GameObject[] aiController;
    public GameObject[] dummyAiController;
    void Start()
    {

       
        StartCoroutine(CountStart());
    }

  IEnumerator CountStart()
    {
        yield return new WaitForSeconds(0.5f);
        countDown.GetComponent<Text>().text = "Ready";
        getReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "Steady";
        getReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown.SetActive(false);
        countDown.GetComponent<Text>().text = "GO";
        getReady.Play();
        countDown.SetActive(true);
        yield return new WaitForSeconds(1f);
        countDown.SetActive(false);
        goAudio.Play();
        levelMusic.Play();
        lapTimer.SetActive(true);
       // carController.enabled = true;
        lapTimeManager.isRaceFinished = false;
        for(int i = 0; i < aiController.Length; i++)
        {
            aiController[i].SetActive(true);
        }
        for (int i = 0; i < dummyAiController.Length; i++)
        {
            dummyAiController[i].SetActive(false);
        }

    }
}
