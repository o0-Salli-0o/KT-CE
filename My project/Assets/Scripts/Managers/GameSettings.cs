using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Manager/GameSettings")]
public class GameSettings : ScriptableObject
{
    [SerializeField]
    private string gameVersion = "0.0.0";

    public string GameVersion { get { return gameVersion; } }

    [SerializeField]
    private string nickname = "Player";

    public string NickName
    {
        get
        {
            int value = Random.Range(1, 2);
            return nickname + value.ToString();
        }
    }
}
