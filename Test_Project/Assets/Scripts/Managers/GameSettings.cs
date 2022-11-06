using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Manager/GameSettings")]

public class GameSettings : ScriptableObject
{
    [SerializeField]
    private string _gameVersion = "0.0.0";

    [SerializeField]
    private Text _nickName;

    public string GameVersion
    {
        get { return _gameVersion; }
    }

    public string NickName
    {
        get 
        {
            return _nickName.text;
        }
    }
}
