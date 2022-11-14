using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestConnect : MonoBehaviourPunCallbacks
{
    [Space(5)]
    public Text connectionStatus;

    // Start is called before the first frame update
    void Start()
    {
        connectionStatus.text = "Connecting to server...";

        print("Connecting to server...");
        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        connectionStatus.text = "Connected to Photon!";
        connectionStatus.color = Color.green;

        print("Connected to server!");
        print(PhotonNetwork.LocalPlayer.NickName);

        PhotonNetwork.JoinLobby();
    }


    public override void OnDisconnected(DisconnectCause cause)
    {
        connectionStatus.text = "Disconnected from server!";

        print("Disconnected from server for reason " + cause.ToString());
    }
}
