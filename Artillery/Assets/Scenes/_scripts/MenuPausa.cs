using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject menuPausa;
    public GameObject menuOpciones;
    //public bool pausaTiempo = false;
    //public float tiempoPausa;
    public void MostrarMenuPausa()
    {
        menuPausa.SetActive(true);
        if (menuOpciones.activeInHierarchy) menuOpciones.SetActive(false);
    }

    public void OcultarMenuPausa()
    {
        menuPausa.SetActive(false);
    }

    public void RegresarAPantallaPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void MostrarMenuOpciones()
    {
        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);
    }

    public void PonerPausa(float nuevaPausa)
    {
        AdministradorJuego.miJuego.TiempoPausa = nuevaPausa;
        AdministradorJuego.miJuego.JuegoPausa = true;
    }

    public void PausarJuego()
    {
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }

    //public void QuitarPausa()
    //{
    //    AdministradorJuego.miJuego.TiempoPausa = 0;
    //    AdministradorJuego.miJuego.JuegoPausa= false;
    //}
}
