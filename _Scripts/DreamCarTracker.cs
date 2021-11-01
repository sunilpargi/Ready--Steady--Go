using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCarTracker : MonoBehaviour
{
    public GameObject theTracker;
    //public GameObject mark1;
    //public GameObject mark2;
    //public GameObject mark3;
    //public GameObject mark4;
    //public GameObject mark5;
    //public GameObject mark6;
    public GameObject[] marks;

    public int markCount;
  
  
    // Update is called once per frame
    void Update()
    {
        if(markCount == 0)
        {
            theTracker.transform.position = marks[0].transform.position;
        }
        if (markCount == 1)
        {
            theTracker.transform.position = marks[1].transform.position;
        }
        if (markCount == 2)
        {
            theTracker.transform.position = marks[2].transform.position;
        }
        if (markCount == 3)
        {
            theTracker.transform.position = marks[3].transform.position;
        }
        if (markCount == 4)
        {
            theTracker.transform.position = marks[4].transform.position;
        }
        if (markCount == 5)
        {
            theTracker.transform.position = marks[5].transform.position;
        }
        if (markCount == 6)
        {
            theTracker.transform.position = marks[6].transform.position;
        }
        if (markCount == 7)
        {
            theTracker.transform.position = marks[7].transform.position;
        }
        if (markCount == 8)
        {
            theTracker.transform.position = marks[8].transform.position;
        }
        if (markCount == 9)
        {
            theTracker.transform.position = marks[9].transform.position;
        }
        if (markCount == 10)
        {
            theTracker.transform.position = marks[10].transform.position;
        }
        if (markCount == 11)
        {
            theTracker.transform.position = marks[11].transform.position;
        }
        if (markCount == 12)
        {
            theTracker.transform.position = marks[12].transform.position;
        }
        if (markCount == 13)
        {
            theTracker.transform.position = marks[13].transform.position;
        }
        if (markCount == 14)
        {
            theTracker.transform.position = marks[14].transform.position;
        }
        if (markCount == 15)
        {
            theTracker.transform.position = marks[15].transform.position;
        }
        if (markCount == 16)
        {
            theTracker.transform.position = marks[16].transform.position;
        }
        if (markCount == 17)
        {
            theTracker.transform.position = marks[17].transform.position;
        }
        if (markCount == 18)
        {
            theTracker.transform.position = marks[18].transform.position;
        }
        if (markCount == 19)
        {
            theTracker.transform.position = marks[19].transform.position;
        }
    }

    private IEnumerator OnTriggerEnter(Collider collision)
    {
        Debug.Log(collision.name);
        if (collision.gameObject.CompareTag("AIGreen") || collision.name == "AIGreen")
        {
            
                this.GetComponent<BoxCollider>().enabled = false;
                markCount += 1;

                if (markCount == 17)
                {
                    markCount = 17;
                    collision.GetComponent<CarController>().enabled = false;


                }

                yield return new WaitForSeconds(.2f);
                this.GetComponent<BoxCollider>().enabled = true;
            
        }

        if (collision.gameObject.CompareTag("AIRed") || collision.name == "AIRed")
        {
           
                this.GetComponent<BoxCollider>().enabled = false;
                markCount += 1;

                if (markCount == 17)
                {
                    markCount = 17;
                    collision.GetComponent<CarController>().enabled = false;


                }

                yield return new WaitForSeconds(.2f);
                this.GetComponent<BoxCollider>().enabled = true;
            
        }

        if (collision.gameObject.CompareTag("AIBlue") || collision.name == "AIBlue")
        {
            
                this.GetComponent<BoxCollider>().enabled = false;
                markCount += 1;

                if (markCount == 17)
                {
                    markCount = 17;
                    collision.GetComponent<CarController>().enabled = false;


                }

                yield return new WaitForSeconds(.2f);
                this.GetComponent<BoxCollider>().enabled = true;
            
        }

        if (collision.gameObject.CompareTag("AIBlueOld") || collision.name == "AIBlueOld")
        {
           
                this.GetComponent<BoxCollider>().enabled = false;
                markCount += 1;

                if (markCount == 17)
                {
                    markCount = 17;
                    collision.GetComponent<CarController>().enabled = false;


                }

                yield return new WaitForSeconds(.2f);
                this.GetComponent<BoxCollider>().enabled = true;
            
        }

        if (collision.gameObject.CompareTag("AiSciFI") || collision.name == "AiSciFI")
        {
           
                this.GetComponent<BoxCollider>().enabled = false;
                markCount += 1;

                if (markCount == 17)
                {
                    markCount = 17;
                    collision.GetComponent<CarController>().enabled = false;


                }

                yield return new WaitForSeconds(.2f);
                this.GetComponent<BoxCollider>().enabled = true;
            
        }
    }
}
