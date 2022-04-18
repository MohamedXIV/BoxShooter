using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMover : MonoBehaviour
{
    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    //private Transform gameobjectTransform;

    private void Start()
    {
        //gameobjectTransform =  GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
        //Debug.Log(Time.timeSinceLevelLoad);
    }
}
