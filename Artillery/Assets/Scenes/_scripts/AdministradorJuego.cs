using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
    public static AdministradorJuego SingletonAdministradorJuego;
    public static ParametrosJuego miJuego = new ParametrosJuego();
    public GameObject MenuFinNivel;
    //public MenuPausa menuPausa;
    float maxTime = 0;
    float currentTime;

    //public static int VelocidadBala = 30;
    //public static int DisparosPorJuego = 10;
    //public static float VelocidadRotacion = 1;

    public GameObject CanvasGanar;
    public GameObject CanvasPerder;


    private void Awake()
    {
        if (SingletonAdministradorJuego == null)
        {
            SingletonAdministradorJuego = this;
            miJuego.VelocidadBala = 30f;
            miJuego.DisparosPorJuego = 7;
            miJuego.VelocidadRotacion = 1f;
            miJuego.FuerzaCanon= 1f;
            miJuego.JuegoPausa = false;
            miJuego.TiempoPausa = 0;
        }
        else
        {
            Debug.LogError("Ya existe una instancia de esta clase ");

        }
       
    }

    public void Start()
    {
        miJuego.JuegoPausa = false;
        //currentTime = 0;
    }

    public void Update()
    {
        if (miJuego.DisparosPorJuego <= 0)
        {
            PerderJuego();
        }
               
        if(Time.timeScale == 1 && miJuego.JuegoPausa == true)
        {
            maxTime = currentTime + miJuego.TiempoPausa;
            //miJuego.JuegoPausa = true;
            Time.timeScale = 0;
            currentTime = 0;
            maxTime = currentTime + miJuego.TiempoPausa;

        }
        else if(Time.timeScale == 0 && miJuego.JuegoPausa == true && currentTime >= maxTime)
        {
            miJuego.JuegoPausa = false;
            Time.timeScale = 1;
        }

        currentTime += Time.deltaTime;
    }

    public void GanarJuego()
    {
        CanvasGanar.SetActive(true);
    }

    public void PerderJuego()
    {
        CanvasPerder.SetActive(true);
        //MenuFinNivel.SetActive(true);
    }


}
