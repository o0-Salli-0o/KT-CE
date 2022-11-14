using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using System.Runtime.CompilerServices;

public class PlayerListing : MonoBehaviour
{
    [SerializeField]
    private Text text;

    public Player Player { get; private set; }

    public void SetPlayerInfo(Player player)
    {
        Player = player;
        text.text = player.NickName;
    }
}
