using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Unlockables : MonoBehaviour
{
    public GameObject SelectCarBtn;
    public GameObject buyCarBtn;
    public GameObject lockedCarText;
    public int cashValue;
    public AudioClip unlockClip;
    public AudioSource UITouchAudioSource;
    void Update()
    {
        cashValue = GlobalCash.totalCash;
       
    }

    public void CarUnlock()
    {

        if (cashValue >= 5000)
        {
            SelectCarBtn.GetComponent<Button>().interactable = true;
        }
        UITouchAudioSource.PlayOneShot(unlockClip);
        lockedCarText.SetActive(false);
        buyCarBtn.SetActive(false);

        cashValue -= 5000;
        GlobalCash.totalCash -= 5000;
        PlayerPrefs.SetInt("SavedCash", cashValue);
        PlayerPrefs.SetInt("GreenCarUnlock", 100);

        gameObject.GetComponent<UnlockObj>().UpdateCoinText(PlayerPrefs.GetInt("SavedCash"));
    }
}
