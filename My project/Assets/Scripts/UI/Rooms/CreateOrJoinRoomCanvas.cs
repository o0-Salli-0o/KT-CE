using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOrJoinRoomCanvas : MonoBehaviour
{
    [SerializeField]
    private CreateRoomMenu createRoomMenu;

    [SerializeField]
    private RoomListingsMenu roomListingsMenu;

    private RoomsCanvases roomsCanvases;

    public void FirstInitalize(RoomsCanvases canvases)
    {
        roomsCanvases = canvases;
        createRoomMenu.FirstInitalize(canvases);
        roomListingsMenu.FirstInitialize(canvases);
    }
}
