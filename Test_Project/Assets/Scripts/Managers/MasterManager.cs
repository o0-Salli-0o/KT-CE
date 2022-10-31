using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Singletons/MasterManager")]

// this is a singleton
public class MasterManager : ScriptableObjectSingleton<MasterManager>
{

    [SerializeField]
    private GameSettings _gameSettings;
    [SerializeField]
    private CreateRoomMenu _createRoomMenu;

    public static GameSettings GameSettings
    {
        get { return Instance._gameSettings; }
    }

    public static CreateRoomMenu CreateRoomMenu
    {
        get { return Instance._createRoomMenu; }
    }

}
