using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStaticInformation : MonoBehaviour
{
    private static string _playerHero = "Man";

    public static string PrefabHero
    {
        get
        {
            return _playerHero;
        }
        set
        {
            _playerHero = value;
        }
    }

    private static string _playerName = "Player";

    public static string PlayerName
    {
        get
        {
            return _playerName;
        }
        set
        {
            _playerName = value;
        }
    }
}
