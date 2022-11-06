using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using UnityEngine.UI;
using Photon.Pun.Demo.PunBasics;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{

    [SerializeField]
    private Text roomName;

    [SerializeField]
    private Text playerName;

    [SerializeField]
    private byte maxPlayersPerRoom = 2;

    //[Space(5)]
    //public Text playerStatus;

    private RoomsCanvases roomsCanvases;

    public void FirstInitialize(RoomsCanvases canvases)
    {
        roomsCanvases = canvases;
    }

    public void OnClick_CreateRoom()
    {
        if (!PhotonNetwork.IsConnected)
        {
            return;
        }

        //JoinOrCreateRoom
        TypedLobby typedLobby = new TypedLobby(roomName.text, LobbyType.Default);
        PhotonNetwork.NickName = this.playerName.text;
        RoomOptions options = new RoomOptions();
        options.MaxPlayers = maxPlayersPerRoom;

        //print(this.playerName + " b");
        PhotonNetwork.JoinOrCreateRoom(roomName.text, options, typedLobby);

    }

    public override void OnCreatedRoom()
    {
        Debug.Log("Created room successfully.", this);
        roomsCanvases.CurrentRoomCanvas.Show();

        //print("Player: " + PhotonNetwork.LocalPlayer.NickName);
        //print("Room: " + PhotonNetwork.CurrentRoom);

        //roomsCanvases.CurrentRoomCanvas.Show();
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room creation failed: " + message, this);
    }

    // TODO: delete
    public string PlayerName
    {
        get
        {
            return playerName.text;
        }
    }
}
