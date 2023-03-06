using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ParametrosJuego
{
    private int velocidadBala;
    private int disparosPorJuego;
    private float velocidadRotacion;

    public int VelocidadBala
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
}
