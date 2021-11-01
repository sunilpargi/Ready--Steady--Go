using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class FinishRace : MonoBehaviour
{
    //public GameObject MyCar;
    //public GameObject dummyMyCar;
    public GameObject finishCam;
    public GameObject viewMode;
    public GameObject levelMusic;
  //  public GameObject CompleteTrig;
    public GameObject finishMusic;
    public int winPosCount;
    public GameObject positionDesplay;
    public GameObject mainMenuBtn;
    public GameObject loadingScreen;
    public AudioSource BGMusic;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("AIRed") || other.CompareTag("Player") || other.CompareTag("AIBlue") || other.CompareTag("AIGreen") || other.CompareTag("AiSciFI") || other.CompareTag("AIBlueOld"))
        {

            winPosCount++;
        }
    
        if (other.CompareTag("Player"))
        {
            BGMusic.Stop();
          //  Debug.Log(winPosCount);
          //  MyCar.SetActive(false);
          // CompleteTrig.SetActive(false);
          // CarController.m_Topspeed = 0f;
          //MyCar.GetComponent<CarController>().enabled = false;
          //MyCar.GetComponent<CarUserControl>().enabled = false;

            // MyCar.SetActive(false);
            //   dummyMyCar.SetActive(true);
            finishMusic.SetActive(true);
            finishCam.SetActive(true);
            levelMusic.SetActive(false);
            viewMode.SetActive(false);
            positionDesplay.GetComponent<Text>().text = "Nice Job" + " " + winPosCount + " " + "Position";
            positionDesplay.GetComponent<Animator>().Play("Positiondesplay");
            mainMenuBtn.SetActive(true);
            StartCoroutine(LoadingScreen());

        }

    }

    public void MainMenubtn()
    {
        Debug.Log(1);
        SceneManager.LoadScene(1);
    }

    IEnumerator LoadingScreen()
    {
        yield return new WaitForSeconds(6f);
        loadingScreen.SetActive(true);
        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(1);
    }
}
