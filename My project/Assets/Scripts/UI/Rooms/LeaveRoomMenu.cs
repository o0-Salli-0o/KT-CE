using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveRoomMenu : MonoBehaviour
{
    private RoomsCanvases roomsCanvas;

    public void FirstInitialize(RoomsCanvases canvases)
    {
        roomsCanvas = canvases;
    }

    public void OnClick_LeaveRoom()
    {
        PhotonNetwork.LeaveRoom(true);
        roomsCanvas.CurrentRoomCanvas.Hide();
    }
}
