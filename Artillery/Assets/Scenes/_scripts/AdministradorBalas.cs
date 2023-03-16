using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorBalas : MonoBehaviour
{
    [HideInInspector] public List<GameObject> balas;
    public GameObject bala_SG_Prebabs;
    private Bala balascript;
    public GameObject MenuFinJuego;

    // Start is called before the first frame update
    void Start()
    {
        Transform[] hijos = GetComponentsInChildren<Transform>();
        foreach(Transform hijo in hijos)
        {
            balas.Add(hijo.gameObject);
        }
        
    }

    public void EliminarBala()
    {
        var objetoAEliminar = balas[balas.Count - 1];
        Destroy(objetoAEliminar);
        balas.RemoveAt(balas.Count - 1);
        AdministradorJuego.miJuego.DisparosPorJuego--;
        this.EliminarBala();
        if (balas.Count < 0)
        {
            MenuFinJuego.SetActive(true);
            return;
        }

        //var bala = Instantiate(bala_SG_Prebabs) as GameObject;
        //balascript = bala.GetComponent<Bala>();
        //balascript.BalaDestruida.AddListener(this.EliminarBala);

    }
}
