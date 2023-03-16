using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "Opciones", menuName = "Herramientas/Opciones", order = 1)]
public class Opciones : ObjetoPersistente
{
    public float velocidadBola = 30;
    public float velocidadRotacion=1; 
    
    
    public void CambiarVelocidadBola(float nuevaVelocidadBola)
    {
        velocidadBola = nuevaVelocidadBola;
    }

    public void CambiarVelocidadRotacion(float nuevaVelocidadRotacion)
    {
        velocidadRotacion = nuevaVelocidadRotacion;
    }

}
