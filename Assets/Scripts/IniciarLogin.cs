using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.UI;
using UnityEngine.SceneManagement;
using GameJolt.API;

public class IniciarLogin : MonoBehaviour
{
    void Start()
    {
        GameJoltUI.Instance.ShowSignIn((bool isSignedIn) =>
        {
            if (isSignedIn)
            {
                SceneManager.LoadScene("LEVEL1");
                Debug.Log("se logueo con exito");
                desbloquearTrofeo();
            }
            else
            {
                Debug.Log("pon lo bien");
            }
        }); 
    }
    void desbloquearTrofeo()
    {
        Trophies.Unlock(233115);
    }
}
