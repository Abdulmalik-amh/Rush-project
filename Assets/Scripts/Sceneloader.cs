using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
  
    // Update is called once per frame

  public GameObject Loadingscreen;
  public Slider LoadingBar;
  public void LoadScene(int LevelIndex){
    StartCoroutine(LoadSceneAsynchronously(LevelIndex));
    
  }
  IEnumerator LoadSceneAsynchronously(int LevelIndex){

    AsyncOperation op =  SceneManager.LoadSceneAsync(LevelIndex);

    Loadingscreen.SetActive(true);

    while(!op.isDone){
        LoadingBar.value = op.progress + 4f;
        yield return null;
    }

  }
}
