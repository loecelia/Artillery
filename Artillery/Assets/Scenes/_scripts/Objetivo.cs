using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Objetivo : MonoBehaviour
{
    public UnityEvent GameWon;
    public UnityEvent AumentarPuntaje;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Explosion")
        {
            AumentarPuntaje.Invoke();
            GameWon.Invoke();
            Destroy(this.gameObject);
        }
    }
}
