using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2Movement : MonoBehaviourPunCallbacks
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
        if (Input.GetKey("1"))
        {
            Debug.Log("1");
            transform.Rotate(0, .5f, 0);
        }
        if (Input.GetKey("2"))
        {
            transform.Rotate(0, -.5f, 0);
        }
    }
}
