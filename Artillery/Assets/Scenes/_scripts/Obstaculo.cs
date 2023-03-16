using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Obstaculo : MonoBehaviour
{
    //public int puntaje; 
    public UnityEvent AumentarPuntaje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Explosion")
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }
}
