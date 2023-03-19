using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderPausaTime : MonoBehaviour
{
    public MenuPausa menupausa;
    Slider slider;

    public void Start()
    {
        slider = this.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { EstablecerTiempoPausa(); });
    }
    public void EstablecerTiempoPausa()
    {
        menupausa.PonerPausa(slider.value);
    }
}
