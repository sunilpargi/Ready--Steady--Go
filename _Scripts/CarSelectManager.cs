using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarSelectManager : MonoBehaviour
{
    public GameObject[] differentCars;
    public GameObject[] differentCarsFeatures;
    public int differentCarsIndex;
    public int differentCarsFeaturesIndex;

    public Animator modeSelectPanelAnim;
    public Animator mapSelectPanelAnim;


    public AudioSource uiTouchSound;
    private void Start()
    {
        differentCars[differentCarsIndex].SetActive(true);
        differentCarsFeatures[differentCarsFeaturesIndex].SetActive(true);
    }
    public void RightArrow()
    {
        uiTouchSound.Play();
        differentCars[differentCarsIndex].SetActive(false);

        differentCarsIndex++;
        if (differentCarsIndex >= differentCars.Length)
        {
            differentCarsIndex = 0;
        }

        differentCars[differentCarsIndex].SetActive(true);

        differentCarsFeatures[differentCarsFeaturesIndex].SetActive(false);// differentCarsFeatures

        differentCarsFeaturesIndex++;
        if (differentCarsFeaturesIndex >= differentCarsFeatures.Length)
        {
            differentCarsFeaturesIndex = 0;
        }

        differentCarsFeatures[differentCarsFeaturesIndex].SetActive(true);


    }

    public void LeftArrow()
    {
        uiTouchSound.Play();
        differentCars[differentCarsIndex].SetActive(false);

        differentCarsIndex--;
        if (differentCarsIndex <= -1)
        {
            differentCarsIndex = differentCars.Length - 1;
        }

        differentCars[differentCarsIndex].SetActive(true);


        differentCarsFeatures[differentCarsFeaturesIndex].SetActive(false);// differentCarsFeatures

        differentCarsFeaturesIndex--;
        if (differentCarsFeaturesIndex <= -1)
        {
            differentCarsFeaturesIndex = differentCarsFeatures.Length - 1;
        }

        differentCarsFeatures[differentCarsFeaturesIndex].SetActive(true);

    }

    public void SelectCarBtn()
    {
        uiTouchSound.Play();
        if (differentCarsIndex == 0)
        {
            GlobalCar.instance.YellowCar();
        }

        if (differentCarsIndex == 1)
        {
            GlobalCar.instance.WhiteCar();
        }

        if (differentCarsIndex == 2)
        {
            GlobalCar.instance.BlackCar();
        }

        if (differentCarsIndex == 3)
        {
            GlobalCar.instance.BlueCar();
        }

        if (differentCarsIndex == 4)
        {
            GlobalCar.instance.RedCar();
        }

        if (differentCarsIndex == 5)
        {
            GlobalCar.instance.GreenCar();
        }
    }


    public void SelectModeBtn()
    {
        uiTouchSound.Play();
        modeSelectPanelAnim.SetTrigger("SlideIn");
    }
    public void BackToGarageBtn()
    {
        uiTouchSound.Play();
        modeSelectPanelAnim.SetTrigger("SlideOut");
    }

    public void BackToSelectModeBtn()
    {
        uiTouchSound.Play();
        mapSelectPanelAnim.SetTrigger("SlideOut");
        modeSelectPanelAnim.SetTrigger("SlideIn");
    }
    public void SelectMapBtn()
    {
        uiTouchSound.Play();
        modeSelectPanelAnim.SetTrigger("SlideOut");
        mapSelectPanelAnim.SetTrigger("SlideIn");
    }
}
