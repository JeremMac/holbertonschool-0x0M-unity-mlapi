using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class ClientConnect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HostConnecButton()
    {
        NetworkManager.Singleton.StartHost();
    }
    public void ClientConnectButton()
    {
        NetworkManager.Singleton.StartClient();
    }
}
