using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class NameInput : MonoBehaviourPunCallbacks
{
    static string playerNamePrefKey = "PlayerName";
    InputField _inputField;

    void Start()
    {
        string defaultName = "";
        _inputField = this.GetComponent<InputField>();
        
        if (_inputField != null)
        {
            if (PlayerPrefs.HasKey(playerNamePrefKey))
            {
                defaultName = PlayerPrefs.GetString(playerNamePrefKey);
                _inputField.text = defaultName;
            }
        }
    }

    public void SetPlayerName()
    {
        PhotonNetwork.NickName = _inputField.text + " ";     //今回ゲームで利用するプレイヤーの名前を設定
        PlayerPrefs.SetString(playerNamePrefKey, _inputField.text);    //今回の名前をセーブ
        Debug.Log(PhotonNetwork.NickName);   //playerの名前の確認。（動作が確認できればこの行は消してもいい）
    }
}
