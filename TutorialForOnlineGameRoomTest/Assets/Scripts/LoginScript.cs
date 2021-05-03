
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class LoginScript : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject connectingPanel;

    void Start()
    {
        connectingPanel.SetActive(false);
    }


    public void Connect()
    {
        if (!PhotonNetwork.IsConnected)            //Photonに接続できていなければ
        {
            PhotonNetwork.ConnectUsingSettings();   //Photonに接続する
            Debug.Log("Photonに接続しました。");
            connectingPanel.SetActive(true);
        }
        else
        {
            Debug.Log("すでに接続されています");
            PhotonNetwork.Disconnect();
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("OnConnectedToMasterが呼ばれました");
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions(), TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("ルームに入りました。");
        PhotonNetwork.LoadLevel("Main");
    }
}
