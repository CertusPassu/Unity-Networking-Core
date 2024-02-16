using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNetworkManager : NetworkManager 
{
    public override void OnServerConnect(NetworkConnectionToClient conn)
    {
        base.OnServerConnect(conn);

        Debug.Log("I connetcetd to the server");
    }

    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);

        MyNetworkPlayer player = conn.identity.GetComponent<MyNetworkPlayer>();
        Color playerColor = new Color(Random.Range(0f, 1f),
                                      Random.Range(0f, 1f),
                                      Random.Range(0f, 1f));
        player.SetPlayerName($"Player {numPlayers}");
        player.SetPlayerColor(playerColor);
    }
}
