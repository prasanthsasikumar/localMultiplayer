using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.Networking;

public class rotatePlayerHand : MonoBehaviour
{
    GameObject noloController;
    private bool isGameInitialised = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       /* if (!GetComponent<PhotonView>().IsMine)
        {
            return;
        }*/
        if (!isGameInitialised)
        {
            isGameInitialised = true;
            noloController = GameObject.Find("RightController");
        }
        
        transform.rotation = noloController.transform.rotation;
    }
}
