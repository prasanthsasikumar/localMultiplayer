using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AttachAndRotateLeft : MonoBehaviour
{

    public GameObject myCamera, leftArm;
    GameObject noloControllerLeft;
    public GameObject textMesh_arm, textMesh_controller;
    private bool isGameInitialised = false;
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

        Debug.Log(isMainPlayer);

        if (PhotonNetwork.CountOfPlayers == 1)
        {
            isMainPlayer = true;
        }
        if (!isGameInitialised)
        {
            isGameInitialised = true;
            GameObject noloManager = GameObject.Find("NoloManager");
            noloManager.GetComponent<NoloVR_Manager>().VRCamera = myCamera;
            noloControllerLeft = GameObject.Find("RightController");
            //noloControllerLeft.transform.SetPositionAndRotation(leftArm.transform.position, leftArm.transform.rotation);
        }
        textMesh_arm.GetComponent<TextMesh>().text = noloControllerLeft.transform.localRotation.ToString();
        //leftArm.transform.localRotation = noloControllerLeft.transform.localRotation;
        
        leftArm.transform.localRotation = ConvertRightHandedToLeftHandedQuaternion(noloControllerLeft.transform.localRotation);
    }

    private Quaternion ConvertRightHandedToLeftHandedQuaternion(Quaternion rightHandedQuaternion)
    {
        return new Quaternion(-rightHandedQuaternion.x,
                                rightHandedQuaternion.z,
                                rightHandedQuaternion.y,
                                 rightHandedQuaternion.w);
    }
}
