using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseSCript : MonoBehaviour
{
     void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene(4);
    }
}
