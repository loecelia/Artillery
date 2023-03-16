using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorObjetos : MonoBehaviour
{
    public GameObject MenuFinNivel;
    public Objetivo objetivo;
    

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            MenuFinNivel.SetActive(true);
        }
    }
}
