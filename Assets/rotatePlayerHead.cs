using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlayerHead : MonoBehaviour
{
    float distance = .01f;
    public GameObject cameraObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("camera looking at x:" + cameraObject.transform.rotation.x);
        Debug.Log("camera looking at y:" + cameraObject.transform.rotation.y);
        Debug.Log("camera looking at z:" + cameraObject.transform.rotation.z);
        Debug.Log("head looking at :" + transform.rotation);

        Vector3 v = transform.rotation.eulerAngles;
        transform.rotation = Quaternion.Euler(v.x, cameraObject.transform.rotation.y, v.z);
        //transform.rotation. = cameraObject.transform.rotation.y;
    }
}
