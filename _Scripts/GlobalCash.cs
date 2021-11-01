using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalCash : MonoBehaviour
{
    public int cashValue;
    public static int totalCash;
    public GameObject cashDisplay;

    public Animator infoPanelAnim;

    private void Start()
    {
        PlayerPrefs.SetInt("SavedCash", 10000);
        PlayerPrefs.SetInt("GreenCarUnlock", 0);
        totalCash = PlayerPrefs.GetInt("SavedCash");
        
    }
    void Update()
    {
        cashValue = totalCash;
        cashDisplay.GetComponent<Text>().text = cashValue.ToString();
    }

    public void InfoPanelBtn()
    {
            infoPanelAnim.SetTrigger("SlideIn");
    }

    public void BackInfopanelBtn()
    {
        infoPanelAnim.SetTrigger("SlideOut");
    }
}
