using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    public bool doSpin = true;
    public bool upMotion = false;
    public bool rightMotion = false;
    // Update is called once per frame
    void Update()
    {
        if (doSpin)
        {
            //rotate around the up axis of the gameObject
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
        if (upMotion)
        {
            //move up and down around the time
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude*Time.deltaTime);
        }
        if (rightMotion) 
        {
            gameObject.transform.Translate(Vector3.right * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude * Time.deltaTime);
        }
    }
}
