using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableControllerScript : MonoBehaviour
{
    public GameObject controller;
    public bool disableController;


    // Start is called before the first frame update
    void Start()
    {
        if (disableController)
        {
            controller.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
