using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;
using Photon.Pun.UtilityScripts;

public class JoinGameMenu : MonoBehaviourPunCallbacks
{
    [Space(5)]
    public Text playerStatus;
    public Text playerOne;
    public Text playerTwo;

    /*[SerializeField]
    private Transform content;

    [SerializeField]
    private PlayerListing playerListing;

    private List<PlayerListing> playerListings = new List<PlayerListing>();

    private void Awake()
    {
        GetCurrentRoomPlayers();
    }

    private void GetCurrentRoomPlayers()
    {
        foreach(KeyValuePair<int, Player> playerInfo in PhotonNetwork.CurrentRoom.Players)
        {
            AddPlayerListing(playerInfo.Value);
        }
    }

    private void AddPlayerListing(Player player)
    {
        PlayerListing playerListing = Instantiate(this.playerListing, content);
        if (playerListing != null)
        {
            playerListing.SetPlayerInfo(player);
            playerListings.Add(playerListing);
            print("other in lobby");
        }
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        AddPlayerListing(newPlayer);
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        int index = playerListings.FindIndex(x => x.Player == otherPlayer);
        if(index != -1)
        {
            Destroy(playerListings[index].gameObject);
            playerListings.RemoveAt(index);
        }
    }*/

    /*public override void OnJoinedRoom()
    {
        if (PhotonNetwork.IsMasterClient)
        { 
            playerStatus.text = "You are Lobby Leader";
            playerOne.text = PhotonNetwork.MasterClient.NickName;
            print("Master in lobby");

        }
        else
        {
            playerStatus.text = "Connected to Lobby";
            playerTwo.text = PhotonNetwork.LocalPlayer.NickName;
            print("other in lobby");
        }
    }*/
}
