using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


    public class CarActive : MonoBehaviour
    {
        public GameObject carController, aiController;
        public GameObject dummycarController, dummyaiController;
        void Start()
        {
            dummycarController.SetActive(false);
            dummyaiController.SetActive(false);

            carController.SetActive(true);
            aiController.SetActive(true);


         }
    }

