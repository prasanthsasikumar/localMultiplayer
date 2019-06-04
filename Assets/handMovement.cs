using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handMovement : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        base.photonView.RequestOwnership();
    }
    // Update is called once per frame
    void Update()
    {
        if (!GetComponent<PhotonView>().IsMine)
        {
            return;
        }
        if (Input.GetKey("left"))
        {
            Debug.Log("Left");
            transform.Rotate(0, .5f, 0);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, -.5f, 0);
        }
    }
}
