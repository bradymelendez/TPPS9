using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cargarnivel : MonoBehaviour
{
    public string Nivel;

    public void cargarnivel()

    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(Nivel);

    }

}
