using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private GameObject BalaPrefab;
    private GameObject puntaCanon;
    //private GameObject AdministradorJuego;
    private float rotacion;

    // Start is called before the first frame update
    void Start()
    {
        puntaCanon = transform.Find("PuntaCanon").gameObject;
        //AdministradorJuego = transform.Find("AdministradorJuego").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        rotacion += Input.GetAxis("Horizontal") * AdministradorJuego.miJuego.VelocidadRotacion;
        if (rotacion <= 90 && rotacion >= 0)
        {
            transform.eulerAngles = new Vector3(rotacion, 90, 0.0f); 
        }
        if (rotacion > 90) rotacion = 90;
        if (rotacion < 0) rotacion = 0;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (AdministradorJuego.miJuego.DisparosPorJuego > 0)
            {
                GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
                Rigidbody tempRB = temp.GetComponent<Rigidbody>();
                Vector3 direccionDisparo = transform.rotation.eulerAngles;
                direccionDisparo.y = 90 - direccionDisparo.x;
                tempRB.velocity = direccionDisparo.normalized  * AdministradorJuego.miJuego.VelocidadBala;
                AdministradorJuego.miJuego.DisparosPorJuego -= 1;
            }
            else
            {
                Application.Quit();
            }            
        }
    }
}
