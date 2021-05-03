using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Voice.PUN;

public class VoiceScript : MonoBehaviourPunCallbacks
{
    private PhotonVoiceView _voice;

    void Start()
    {
        if (photonView.IsMine)
        {
            _voice = GetComponent<PhotonVoiceView>();
            _voice.RecorderInUse.TransmitEnabled = true;
        }
    }

    
    void Update()
    {
        
    }
}
