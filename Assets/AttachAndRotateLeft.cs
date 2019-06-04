using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AttachAndRotateLeft : MonoBehaviour
{
    public GameObject myCamera, leftArm, rightArm;
    GameObject noloControllerLeft;
    private bool isGameInitialised = false;
    public bool attachArmToController = false;
    private bool isMainPlayer = false;

    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<PhotonView>().IsMine)
        {
            return;
        }
        myCamera.SetActive(true);

        Debug.Log(isMainPlayer);

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
            noloControllerLeft = GameObject.Find("RightController");
            noloControllerLeft.transform.SetPositionAndRotation(leftArm.transform.position, leftArm.transform.rotation);
        }
        if (attachArmToController)
        {
            leftArm.transform.localRotation = noloControllerLeft.transform.localRotation;
        }
    }
}
