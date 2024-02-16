using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using TMPro;

public class MyNetworkPlayer : NetworkBehaviour
{
    [SyncVar]
    [SerializeField]
    private string playerName = "Missing Name";
    [SyncVar]
    [SerializeField]
    private Color playerColor = Color.red;


    [Server]    
    public void SetPlayerName(string newPlayerName)
    {
        playerName = newPlayerName;    
    }
    [Server]
    public void SetPlayerColor(Color newPlayerColor)
    {
        playerColor = newPlayerColor;
    }
}
