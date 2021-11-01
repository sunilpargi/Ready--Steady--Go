using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UnlockObj : MonoBehaviour
{
    public int greenCarUnlock;
    public GameObject buyCarBtn;
    public GameObject lockedCarText;

    public int cashValue;
    public static int totalCash;
    public GameObject cashDisplay;
    void Start()
    {
        totalCash = PlayerPrefs.GetInt("SavedCash");
        UpdateCoinText(totalCash);

        greenCarUnlock = PlayerPrefs.GetInt("GreenCarUnlock");

        if (greenCarUnlock == 100)
        {
            buyCarBtn.SetActive(false);
            lockedCarText.SetActive(false);
        }
    }

   public void UpdateCoinText(int _value)
    {
        cashValue = _value;
        cashDisplay.GetComponent<Text>().text = cashValue.ToString();
    }

}
