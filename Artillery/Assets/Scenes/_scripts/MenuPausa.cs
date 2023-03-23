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
        AdministradorJuego.miJuego.PausarTimeScaleJuego(true);
    }

    public void OcultarMenuPausa()
    {
        menuPausa.SetActive(false);
        AdministradorJuego.miJuego.PausarTimeScaleJuego(false);
    }

    public void RegresarAPantallaPrincipal()
    {
        SceneManager.LoadScene(0);
        AdministradorJuego.miJuego.PausarTimeScaleJuego(false);
    }

    public void MostrarMenuOpciones()
    {
        menuPausa.SetActive(false);
        menuOpciones.SetActive(true);
    }

    public void PonerPausa(float nuevaPausa)
    {
        AdministradorJuego.miJuego.TiempoPausa = nuevaPausa;
        AdministradorJuego.miJuego.PausarTimeScaleJuego(true);

    }

    public void PausarJuego()
    {
        if (Time.timeScale == 1.0f) //(Time.timeScale == 0)
        {
            Time.timeScale = 0.0f;            
        }
        else
        {
            Time.timeScale = 1.0f;            
        }
    }

    public void QuitarPausa(float nuevaPausa)
    {
        AdministradorJuego.miJuego.TiempoPausa = nuevaPausa;
        AdministradorJuego.miJuego.PausarTimeScaleJuego(true);
    }
}
