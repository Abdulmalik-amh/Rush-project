using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;


public class Rooms : MonoBehaviourPunCallbacks
{
   public TMP_InputField create;
   public TMP_InputField join;

    public void Create(){
        PhotonNetwork.CreateRoom(create.text);
    }
    
    public void Join(){
        PhotonNetwork.JoinRoom(join.text);
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.LoadLevel(2);
    }

    public override void OnCreatedRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }
}
