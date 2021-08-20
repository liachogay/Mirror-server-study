using Mirror;
using UnityEngine;
using UnityEngine.UI;

public class MenuNetworkHUD : MonoBehaviour
{
    public Button hostButton,serverButton,clientButton;

    private void Start()
    {
        hostButton.onClick.AddListener(ButtonHost);
        serverButton.onClick.AddListener(ServerButton);
        clientButton.onClick.AddListener(ClientButton);
    }

    private void ButtonHost()
    {
        NetworkManager.singleton.StartHost();
    }

    private void ServerButton()
    {
        NetworkManager.singleton.StartServer();
    }

    private void ClientButton()
    {
        NetworkManager.singleton.StartClient();
    }

    private void ButtonStop()
    {
        //server and client
        if (NetworkServer.active && NetworkClient.active)
        {
            NetworkManager.singleton.StopHost();
        }
        //client
        else if (NetworkClient.active)
        {
            NetworkManager.singleton.StopClient();
        }
        //server
        else if (NetworkServer.active)
        {
            NetworkManager.singleton.StopServer();
        }
    }
}
