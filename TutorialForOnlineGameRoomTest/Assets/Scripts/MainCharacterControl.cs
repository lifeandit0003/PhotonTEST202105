using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class MainCharacterControl : MonoBehaviour
{
    //オンライン化に必要なコンポーネントを設定
    public PhotonView myPV;
    public PhotonTransformView myPTV;
    private Camera mainCam;

    void Start()
    {
        if (myPV.IsMine)    //自キャラであれば実行
        {
            //MainCameraのtargetにこのゲームオブジェクトを設定
            mainCam = Camera.main;
            mainCam.GetComponent<CameraScript>().target = this.gameObject.transform;
        }
    }

}
