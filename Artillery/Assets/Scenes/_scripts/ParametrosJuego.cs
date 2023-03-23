using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ParametrosJuego
{
    private float velocidadBala;
    private int disparosPorJuego;
    private float velocidadRotacion;
    private float fuerzaCanon;
    private bool juegoPausa;
    private float tiempoPausa;

    
    public float VelocidadBala
    {
        get
        {
            return velocidadBala;
        }
        set
        {
            velocidadBala = value;
        }
    }

    public int DisparosPorJuego
    {
        get
        {
            return disparosPorJuego;
        }
        set
        {
            disparosPorJuego = value;
        }
    }

    public float VelocidadRotacion
    {
        get
        {
            return velocidadRotacion;
        }
        set
        {
            velocidadRotacion  = value;
        }
    }

    public float FuerzaCanon
    {
        get
        {
            return fuerzaCanon;
        }
        set
        {
            fuerzaCanon = value;
        }
    }

    public bool JuegoPausa
    {
        get
        {
            return juegoPausa;
        }
        set
        {
            juegoPausa = value;
        }
    }

    public float TiempoPausa
    {
        get
        {
            return tiempoPausa;
        }
        set
        {
            tiempoPausa = value;
        }
    }

    //public void PausarTimeJuego()
    //{
    //    juegoPausa = true;
    //    Time.timeScale = 0.0f;
    //}

    //public void UnPauseTimeJuego()
    //{
    //    juegoPausa = false;
    //    Time.timeScale = 1.0f;
    //}

    //
    public void PausarTimeScaleJuego(bool newJuegoPausa)
    {
        if (newJuegoPausa)
        {
            Time.timeScale = 0.0f;
        }
        else
        {
            Time.timeScale = 1.0f;
        }
        juegoPausa = newJuegoPausa;
    }

}
