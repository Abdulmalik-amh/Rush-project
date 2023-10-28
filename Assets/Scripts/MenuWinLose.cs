using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Photon.Pun;
public class MenuWinLose : MonoBehaviour
{
    public void restartGame(){

        SceneManager.LoadScene(2);
    }

    public void Exit(){

        PhotonNetwork.Disconnect();
        Application.Quit();
        // Application.Quit();
        // Debug.Log("Quit");
    //    Process.GetCurrentProcess().Kill();

    }
}
