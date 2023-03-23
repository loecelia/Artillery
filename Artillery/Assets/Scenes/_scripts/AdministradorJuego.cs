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
        
    }

    public void GanarJuego()
    {
        CanvasGanar.SetActive(true);
        miJuego.PausarTimeScaleJuego(true);
    }

    public void PerderJuego()
    {
        CanvasPerder.SetActive(true);
        miJuego.PausarTimeScaleJuego(true);
    }


}
