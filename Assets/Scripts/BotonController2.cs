using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class BotonController2 : MonoBehaviour
{
    public List<Button> botones = new List<Button>();
    private bool[] seleccionados;

    void Start()
    {
        seleccionados = new bool[botones.Count]; 

        for (int i = 0; i < botones.Count; i++)
        {
            int index = i;
            botones[i].onClick.AddListener(() => OnClick(index)); 
        }
    }

    void OnClick(int index)
    {
        if (!seleccionados[index])
        {
            botones[index].interactable = false;
            seleccionados[index] = true;
        }
    }
}