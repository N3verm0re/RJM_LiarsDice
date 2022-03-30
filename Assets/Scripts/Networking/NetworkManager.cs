using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;

public class NetworkManager : MonoBehaviour
{
    #region Singleton
    public static NetworkManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }

    #endregion

    //Info
    private string myAddress;
    private string connectAddress;
    private string myPassword;
    private string connectPassword;
    private int defaultPort = 57666;

    private void Start()
    {
        //Get this machines ip address for hosting
        string hostName = Dns.GetHostName();
        myAddress = Dns.GetHostEntry(hostName).AddressList[0].ToString();
    }

    private void Update()
    {
        
    }

    public void SetConnectionAddress(string address)
    {
        connectAddress = address;
    }

    public void SetConnectionPassword(string password)
    {
        connectPassword = password;
    }

    public void SetLobbyPassword(string password)
    {
        myPassword = password;
    }
}
