using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;

public class Canon : MonoBehaviour
{
    public static bool Bloqueado;
    public float fuerzaCanon = 0.5f;
    Opciones opciones;
    Slider sliderfuerza;

    public AudioClip clipDisparo;
    private GameObject SonidoDisparo;
    private AudioSource SourceDisparo;


    [SerializeField] private GameObject BalaPrefab;
    public GameObject ParticulasDisparo;
    private GameObject puntaCanon;
    //private GameObject AdministradorJuego;
    private float rotacion;

    public CanonControls canonControls;
    private InputAction apuntar;
    private InputAction modificarFuerza;
    private InputAction disparar;

    public Transform transformNumeroBalas;
    public TMP_Text textoNumeroBalas;
    
    private void Awake()
    {
        canonControls = new CanonControls(); 
    }

    private void OnEnable()
    {
        apuntar = canonControls.Canon.Apuntar;
        modificarFuerza = canonControls.Canon.ModificarFuerza;
        disparar = canonControls.Canon.Disparar;
        apuntar.Enable();
        modificarFuerza.Enable();
        modificarFuerza.performed += ModificarFuerza;
        disparar.Enable();
        //    disparar.performed += Disparar;
        disparar.performed += Disparar;
        AdministradorJuego.miJuego.DisparosPorJuego--;
                         
        //if (AdministradorJuego.miJuego.DisparosPorJuego > 0)
        //{
            
        //}
        //else
        //{
        //    Application.Quit();
        //}        
    }


    // Start is called before the first frame update
    void Start()
    {
        puntaCanon = transform.Find("PuntaCanon").gameObject;
        //AdministradorJuego = transform.Find("AdministradorJuego").gameObject;
        SonidoDisparo = GameObject.Find("SonidoDisparo");
        SourceDisparo = SonidoDisparo.GetComponent<AudioSource>();
        transformNumeroBalas = GameObject.Find("NumeroBalas").transform;
        textoNumeroBalas = transformNumeroBalas.GetComponent<TMP_Text>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (AdministradorJuego.miJuego.JuegoPausa == false)
        {
            rotacion += apuntar.ReadValue<float>() * AdministradorJuego.miJuego.VelocidadRotacion;
            if (rotacion <= 90 && rotacion >= 0)
            {
                transform.eulerAngles = new Vector3(rotacion, 90, 0.0f);
            }
            if (rotacion > 90) rotacion = 90;
            if (rotacion < 0) rotacion = 0;
            textoNumeroBalas.text = $"NumeroBalas: {AdministradorJuego.miJuego.DisparosPorJuego}";
        }
        
    }

    private void Disparar(InputAction.CallbackContext context)
    {
       
        if (AdministradorJuego.miJuego.DisparosPorJuego > 0 && Bloqueado == false && AdministradorJuego.miJuego.JuegoPausa == false)
        {
            GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
            Rigidbody tempRB = temp.GetComponent<Rigidbody>();
            SeguirCamara.objetivo = temp;
            Vector3 direccionDisparo = transform.rotation.eulerAngles;
            direccionDisparo.y = 90 - direccionDisparo.x;
            Vector3 direccionParticulas = new Vector3(-90 + direccionDisparo.x, 90, 0);
            GameObject Particulas = Instantiate
                (ParticulasDisparo, puntaCanon.transform.position, Quaternion.Euler(direccionParticulas), transform);
            tempRB.velocity = direccionDisparo.normalized * (AdministradorJuego.miJuego.VelocidadBala * AdministradorJuego.miJuego.FuerzaCanon);
            //GameObject Particulas = Instantiate(ParticulasDisparo, puntaCanon.transform.position, Vector3.zero);
            AdministradorJuego.miJuego.DisparosPorJuego -= 1;
            SourceDisparo.PlayOneShot(clipDisparo);
            //SourceDisparo.Play();                 
            Bloqueado = true;
        }
    }

    private void ModificarFuerza(InputAction.CallbackContext context)
    {
        //GetComponent<Rigidbody>().AddForce(new Vector3(AdministradorJuego.miJuego.FuerzaCanon, 0, 0));
        Debug.Log(modificarFuerza.ReadValue<float>());
        if (modificarFuerza.ReadValue<float>() == 1) sliderfuerza.value += 0.1f;
        if (modificarFuerza.ReadValue<float>() == -1) sliderfuerza.value -= 0.1f;

        if (sliderfuerza.value > 1.0f) sliderfuerza.value = 1.0f;
        else if (sliderfuerza.value < 0.5f) sliderfuerza.value = 0.5f;
    }

   
}
