using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPausaTime : MonoBehaviour
{
    public MenuPausa menupausa;
    Slider slider;
    float timer, retraso;
    

    public void Start()
    {
        slider = this.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { EstablecerTiempoPausa(); });
        timer = 0;
    }

    public void Update()
    {
        timer += Time.deltaTime;
    }

    public void EstablecerTiempoPausa()
    {
        menupausa.PonerPausa(slider.value);
        retraso = AdministradorJuego.miJuego.TiempoPausa;
        //AdministradorJuego.miJuego.PausarTimeScaleJuego(true);
        new WaitForSeconds(retraso);
        //AdministradorJuego.miJuego.PausarTimeScaleJuego(false);
        menupausa.QuitarPausa(0.0f);
    }
}
