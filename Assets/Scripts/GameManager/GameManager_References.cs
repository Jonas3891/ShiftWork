﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_References : MonoBehaviour
{

    public string playerTag;
    public static string _playerTag;

    public string enemyTag;
    public static string _enemyTag;

    public static GameObject _player;

    private void OnEnable()
    {
        if(playerTag == "")
        {
            Debug.LogWarning("Please type in the name of the player tag in the GameManager _References" +
                " slot in the insepector or else the system will not work");
        }

        if (enemyTag == "")
        {
            Debug.LogWarning("Please type in the name of the enemy tag in the GameManager _References" +
                " slot in the insepector or else the system will not work");
        }

        _playerTag = playerTag;
        _enemyTag = enemyTag;

        _player = GameObject.FindGameObjectWithTag(_playerTag);
    }
}
