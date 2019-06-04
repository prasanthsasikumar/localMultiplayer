using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class driveCar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float speed = 10.0F;
    float rotationSpeed = 100.0F;

    // Update is called once per frame
    void Update()
    {
        float transaltion = CrossPlatformInputManager.GetAxis("Vertical") * speed;
        float rotation = CrossPlatformInputManager.GetAxis("Horizontal") * rotationSpeed;

        transaltion *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, transaltion);
        transform.Rotate(0, rotation, 0);
    }
}
