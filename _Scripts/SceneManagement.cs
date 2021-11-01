using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public AudioSource uiTouchSound;
    public GameObject loadingScreen;
    public void MainMenu()
    {
        uiTouchSound.Play();
        loadingScreen.SetActive(true);
        StartCoroutine(ChangeScene(0));
    }

   
    public void SnowMountainScene()
    {
        uiTouchSound.Play();
        loadingScreen.SetActive(true);
        StartCoroutine(ChangeScene(2));
    }

    public void ModernCityScene()
    {
        uiTouchSound.Play();
        loadingScreen.SetActive(true);
        StartCoroutine(ChangeScene(3));
       
    }

    public void PlayGame()
    {
        uiTouchSound.Play();
       
        loadingScreen.SetActive(true);
        StartCoroutine(ChangeScene(1));
    }

    IEnumerator ChangeScene(int index)
    {
        yield return new WaitForSeconds(3f);
        
        SceneManager.LoadScene(index);
    }


  
}
