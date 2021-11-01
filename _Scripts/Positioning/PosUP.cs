using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PosUP : MonoBehaviour
{
    public GameObject posDisplay;
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "CarPos")
        {
            posDisplay.GetComponent<Text>().text = "1st";
        }
    }
}
