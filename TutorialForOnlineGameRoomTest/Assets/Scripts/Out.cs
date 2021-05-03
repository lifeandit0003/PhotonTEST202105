using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;


public class Out : MonoBehaviourPunCallbacks
{
    PhotonView myPV;
    void Start()
    {
    }


    public void OnTriggerEnter(Collider col)
    {
        myPV = col.gameObject.GetComponent<PhotonView>();

        if (myPV.IsMine)
        {
            //PhotonNetwork.Disconnect();
            SceneManager.LoadScene(0);
        }
    }

}
