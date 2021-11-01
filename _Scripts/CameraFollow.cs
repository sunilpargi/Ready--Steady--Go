using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followTarget;
    public float height;
    public float distance ;
    public float speed;
    public float damping;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, followTarget.transform.position +
            followTarget.transform.TransformDirection(new Vector3(0f,height, distance)), Time.deltaTime * speed);
     
    }
}
