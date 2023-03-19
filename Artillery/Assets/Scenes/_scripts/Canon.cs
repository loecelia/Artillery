using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Canon : MonoBehaviour
{
    public static bool Bloqueado;

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
        rotacion += apuntar.ReadValue<float>() * AdministradorJuego.miJuego.VelocidadRotacion;
        if (rotacion <= 90 && rotacion >= 0)
        {
            transform.eulerAngles = new Vector3(rotacion, 90, 0.0f);
        }
        if (rotacion > 90) rotacion = 90;
        if (rotacion < 0) rotacion = 0;
        textoNumeroBalas.text = $"NumeroBalas: {AdministradorJuego.miJuego.DisparosPorJuego}";
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
            tempRB.velocity = direccionDisparo.normalized * AdministradorJuego.miJuego.VelocidadBala;
            //GameObject Particulas = Instantiate(ParticulasDisparo, puntaCanon.transform.position, Vector3.zero);
            AdministradorJuego.miJuego.DisparosPorJuego -= 1;
            SourceDisparo.PlayOneShot(clipDisparo);
            //SourceDisparo.Play();                 
            Bloqueado = true;
        }
    }

    private void ModificarFuerza(InputAction.CallbackContext context)
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(AdministradorJuego.miJuego.FuerzaCanon, 0, 0));
    }
}
