using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameJolt.UI;
using GameJolt.API;
public class ActivarTrofeosEnVictoria : MonoBehaviour
{

    void Start()
    {
        GameJoltUI.Instance.ShowTrophies();
    }
}
