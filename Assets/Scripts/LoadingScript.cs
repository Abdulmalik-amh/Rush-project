using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviourPunCallbacks
{

    //public GameObject Loader;
    public Slider slider;
    private float sceneLoadTime;
    private string fileName = "scene_load_times.txt";

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        sceneLoadTime = Time.time;
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        OnSceneLoaded();
        SceneManager.LoadScene(1);
    }

    private void OnSceneLoaded()
    {
        // Calculate the scene load time.
        float loadTime = Time.time - sceneLoadTime;

        // Log the scene load time to the console.
        //Debug.Log("Scene load time: " + loadTime);

        // Adding value of the time taken to the slider 

        slider.value = loadTime;
    

        // Log the scene load time to a file.
        using (StreamWriter sw = File.AppendText(fileName))
        {
            sw.WriteLine(loadTime);
        }
    }
}

