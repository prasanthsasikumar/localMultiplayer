using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManagerPhoton : MonoBehaviourPunCallbacks
{

    public string player1PrefabName = "spawn_Photon";
    public string player2PrefabName = "Cube2";
    public string viewer = "viewer";
    public string roomName = "abi";
    public GameObject spawnPoint1, spawnPoint2, spawnPoint3;

    private GameObject myPlayer,mySpawnPos;
    

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
            changePrefab();
        }
        if (NoloVR_Controller.GetDevice(NoloDeviceType.LeftController).GetNoloButtonUp(NoloButtonID.Trigger))
        {
            changePrefab();
        }
        if (NoloVR_Controller.GetDevice(NoloDeviceType.RightController).GetNoloButtonUp(NoloButtonID.Trigger))
        {
            changePrefab();
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMaster() was called by PUN.");
        OnJoinedLobby();
    }

    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log("Joined Lobby");
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.IsVisible = false;
        roomOptions.MaxPlayers = 4;
        PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        if (PhotonNetwork.CountOfPlayers == 2)
        {
            myPlayer = PhotonNetwork.Instantiate(player2PrefabName, spawnPoint2.transform.position, spawnPoint2.transform.rotation, 0);
            myPlayer.name = "Player2";
            mySpawnPos = spawnPoint2;
        }else if (PhotonNetwork.CountOfPlayers > 2)
        {
            myPlayer = PhotonNetwork.Instantiate(viewer, spawnPoint3.transform.position, spawnPoint3.transform.rotation, 0);
            myPlayer.name = "viewer";
            mySpawnPos = spawnPoint3;
        }
        else
        {
            myPlayer = PhotonNetwork.Instantiate(player1PrefabName, spawnPoint1.transform.position, spawnPoint1.transform.rotation, 0);
            myPlayer.name = "Player1";
            mySpawnPos = spawnPoint1;
        }
    }

    public override void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
    {
        Debug.Log("Stats baby!");
        string countPlayersOnline;
        countPlayersOnline = PhotonNetwork.CountOfPlayers.ToString() + " Players Online";
    }

    public void changePrefab()
    {
        if (myPlayer.name == "Player2")
        {
            Debug.Log(myPlayer.name + " is being replaced");
            PhotonNetwork.Destroy(myPlayer);
            myPlayer = PhotonNetwork.Instantiate(player1PrefabName, mySpawnPos.transform.position, mySpawnPos.transform.rotation, 0);
            myPlayer.name = "Player1";
        }
        else
        {
            Debug.Log(myPlayer.name + " is being replaced");
            PhotonNetwork.Destroy(myPlayer);
            myPlayer = PhotonNetwork.Instantiate(player2PrefabName, mySpawnPos.transform.position, mySpawnPos.transform.rotation, 0);
            myPlayer.name = "Player2";
        }    
    }


}
