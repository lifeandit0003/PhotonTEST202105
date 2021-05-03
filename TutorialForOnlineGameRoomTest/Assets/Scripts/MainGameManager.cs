using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class MainGameManager : MonoBehaviourPunCallbacks
{
    //誰かがログインする度に生成するプレイヤーPrefab
    public GameObject playerPrefab;

    void Start()
    {
        if (!PhotonNetwork.IsConnected)   //Phootnに接続されていなければ
        {
            SceneManager.LoadScene("Login"); //ログイン画面に戻る
            return;
        }
        //Photonに接続していれば自プレイヤーを生成
        var StartPos = new Vector3(UnityEngine.Random.Range(-3f, 3f), 0f, UnityEngine.Random.Range(-3f, 3f));
        GameObject Player = PhotonNetwork.Instantiate(this.playerPrefab.name, StartPos, Quaternion.identity, 0);
    }


    void OnGUI()
    {
        //ログインの状態を画面上に出力
        GUILayout.Label(PhotonNetwork.NetworkClientState.ToString());
    }

}
