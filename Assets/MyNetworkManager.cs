using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager
{
    private NetworkManager networkManager;


    public void MyStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " - Starting Host");

        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log(Time.timeSinceLevelLoad + " - Host Started");
    }

    public override void OnStartClient(NetworkClient client)
    {
        // base.OnStartClient(client);

        Debug.Log(Time.timeSinceLevelLoad + " - Client Started Requested");

        InvokeRepeating("PrintDots", 0f, 1f);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        // base.OnClientConnect(conn);

        Debug.Log(Time.timeSinceLevelLoad + " - Client Connected on IP : " + conn.address);

        CancelInvoke();
    }

    private void PrintDots()
    {
        Debug.Log(".");
    }
}