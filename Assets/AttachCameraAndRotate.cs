using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AttachCameraAndRotate : MonoBehaviour
{

    public GameObject myCamera, rightArm;
    GameObject noloControllerRight;
    private bool isGameInitialised = false;
    public bool attachArmToController = false;
    private bool isMainPlayer = false;

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<PhotonView>().IsMine)
        {
            Debug.Log(GetComponent<PhotonView>());
            return;
        }
        myCamera.SetActive(true);

        Debug.Log(this.gameObject);

        if (PhotonNetwork.CountOfPlayers == 1)
        {
            isMainPlayer = true;
            attachArmToController = true;
        }
        if (!isGameInitialised)
        {
            isGameInitialised = true;
            GameObject noloManager = GameObject.Find("NoloManager");
            noloManager.GetComponent<NoloVR_Manager>().VRCamera = myCamera;
            noloControllerRight = GameObject.Find("RightController");
            noloControllerRight.transform.SetPositionAndRotation(rightArm.transform.position, rightArm.transform.rotation);
        }
        if (attachArmToController)
        {
            rightArm.transform.localRotation = noloControllerRight.transform.localRotation;
        }
    }
}
