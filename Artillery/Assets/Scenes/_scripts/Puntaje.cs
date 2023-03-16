using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoActual;
    public PuntajeAlto puntajeAltoSO;
    

    // Start is called before the first frame update
    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        textoActual = transformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = transformPuntajeAlto.GetComponent<TMP_Text>();
        puntajeAltoSO.Cargar();
        textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}";
        puntajeAltoSO.puntajeActual = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        textoActual.text = $"PuntajeActual: {puntajeAltoSO.puntajeActual}";
        if (puntajeAltoSO.puntajeActual > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntajeActual;
            textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.Guardar();     
        }

    }

    public void AumentarPuntaje(int puntos)
    {
        puntajeAltoSO.puntajeActual += puntos;
    }
}
