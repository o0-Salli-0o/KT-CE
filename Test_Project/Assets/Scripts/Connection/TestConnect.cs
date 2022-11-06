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

    //public string playerName = "";
    //string roomName = "";

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteAll();

        print("Connecting to server...");
        ConnectToPhoton();
    }

    public override void OnConnectedToMaster()
    {

        connectionStatus.text = "Connected to Photon!";
        connectionStatus.color = Color.green;

        print("Connected to server!");
        // here we get the nickname that is on the server
        //print(PhotonNetwork.LocalPlayer.NickName);

        PhotonNetwork.JoinLobby();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected from server for reason " + cause.ToString());
    }

    private void ConnectToPhoton()
    {
        connectionStatus.text = "Connecting...";

        // here the nickname was set locally and that will be set to the server
        //PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }
}
