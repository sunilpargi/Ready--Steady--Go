using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject normalCam;
    public GameObject farCam;
    public GameObject fpsCam;
    public int camCount;
  
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("ViewMode"))
        {
            if (camCount == 2)
            {
                camCount = 0;
            }

            else
            {
                camCount += 1;
            }

            StartCoroutine(ModeChange());
        }

    }

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(.1f);

        if(camCount == 0)
        {
            normalCam.SetActive(true);
            fpsCam.SetActive(false);
        }

        if(camCount == 1)
        {
            farCam.SetActive(true);
            normalCam.SetActive(false);
        }

        if(camCount == 2)
        {
            fpsCam.SetActive(true);
            farCam.SetActive(false);
        }
    }
}
