using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerGenerator : MonoBehaviour
{
   public float minX , maxX, minY, maxY;
   public GameObject playerPerfab;

    void Start()
    {
        Vector3 random = new Vector3 (Random.Range(maxX,minX),100.0f,Random.Range(maxY,minY));

        PhotonNetwork.Instantiate(playerPerfab.name,random,Quaternion.identity);
    }

 
}
