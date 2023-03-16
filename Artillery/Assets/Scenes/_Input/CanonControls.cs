// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/_Input/CanonControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @CanonControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @CanonControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CanonControls"",
    ""maps"": [
        {
            ""name"": ""Canon"",
            ""id"": ""536685a4-226a-46f6-9bfc-96471344b417"",
            ""actions"": [
                {
                    ""name"": ""Apuntar"",
                    ""type"": ""Button"",
                    ""id"": ""e476bb92-6f81-4867-8ca9-f9ff457a3536"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Disparar"",
                    ""type"": ""Button"",
                    ""id"": ""dcc5e880-a1d3-45e2-927c-ff07bea2af0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ModificarFuerza"",
                    ""type"": ""Button"",
                    ""id"": ""64af3fac-3bc5-403f-b72e-1d3af26e78ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""e9ae5764-2281-4268-a93e-438134a5d2f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Teclado"",
                    ""id"": ""bcf44b49-fc33-46b8-aa00-a38534c16439"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Apuntar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b60ac0fb-bd51-4aa4-b8b2-c346e7a003fe"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""13da3457-2f72-4467-bfcf-1f448b01c98a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Control"",
                    ""id"": ""69522292-602b-4a60-a9e8-6a3c812d6dba"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c4e57ddb-9b9a-47b1-be6e-f76d56c5818f"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""782592a4-5d84-4021-a6b5-fe64ec6d57ff"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Apuntar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b1028f55-9d9b-478a-9186-1461d60929f4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Generica"",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6beba517-982f-4e81-97ce-d73d9793e08b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Control"",
                    ""id"": ""81da8496-d56d-4a2b-9079-9e675e9a9a7a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ee67700a-c471-4963-9358-7dfde2ea2427"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""62442a90-aea1-4c12-a38e-190ae6ba36e5"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Teclado"",
                    ""id"": ""f1b91389-63ee-4aa3-890c-ac6f09f0bc7b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""62a0249b-9301-457b-866d-46cfee94e566"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""47757c0c-1670-442f-a594-425af17bd782"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ModificarFuerza"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2116cf5d-0724-4d1a-8651-6ba00564e75b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""93bc0cb6-8cc8-4c27-9f64-1dcefb8600f0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""06110c52-b860-45f8-b4a9-e9b9775bee8a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e5552f80-2feb-4fbd-9062-f7ef55b10597"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bd44bae3-5928-4f30-a814-29b4aadce381"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Generica"",
            ""bindingGroup"": ""Generica"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Canon
        m_Canon = asset.FindActionMap("Canon", throwIfNotFound: true);
        m_Canon_Apuntar = m_Canon.FindAction("Apuntar", throwIfNotFound: true);
        m_Canon_Disparar = m_Canon.FindAction("Disparar", throwIfNotFound: true);
        m_Canon_ModificarFuerza = m_Canon.FindAction("ModificarFuerza", throwIfNotFound: true);
        m_Canon_Move = m_Canon.FindAction("Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Canon
    private readonly InputActionMap m_Canon;
    private ICanonActions m_CanonActionsCallbackInterface;
    private readonly InputAction m_Canon_Apuntar;
    private readonly InputAction m_Canon_Disparar;
    private readonly InputAction m_Canon_ModificarFuerza;
    private readonly InputAction m_Canon_Move;
    public struct CanonActions
    {
        private @CanonControls m_Wrapper;
        public CanonActions(@CanonControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Apuntar => m_Wrapper.m_Canon_Apuntar;
        public InputAction @Disparar => m_Wrapper.m_Canon_Disparar;
        public InputAction @ModificarFuerza => m_Wrapper.m_Canon_ModificarFuerza;
        public InputAction @Move => m_Wrapper.m_Canon_Move;
        public InputActionMap Get() { return m_Wrapper.m_Canon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CanonActions set) { return set.Get(); }
        public void SetCallbacks(ICanonActions instance)
        {
            if (m_Wrapper.m_CanonActionsCallbackInterface != null)
            {
                @Apuntar.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Apuntar.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Apuntar.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnApuntar;
                @Disparar.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @Disparar.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @Disparar.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnDisparar;
                @ModificarFuerza.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @ModificarFuerza.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @ModificarFuerza.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnModificarFuerza;
                @Move.started -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CanonActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_CanonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Apuntar.started += instance.OnApuntar;
                @Apuntar.performed += instance.OnApuntar;
                @Apuntar.canceled += instance.OnApuntar;
                @Disparar.started += instance.OnDisparar;
                @Disparar.performed += instance.OnDisparar;
                @Disparar.canceled += instance.OnDisparar;
                @ModificarFuerza.started += instance.OnModificarFuerza;
                @ModificarFuerza.performed += instance.OnModificarFuerza;
                @ModificarFuerza.canceled += instance.OnModificarFuerza;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public CanonActions @Canon => new CanonActions(this);
    private int m_GenericaSchemeIndex = -1;
    public InputControlScheme GenericaScheme
    {
        get
        {
            if (m_GenericaSchemeIndex == -1) m_GenericaSchemeIndex = asset.FindControlSchemeIndex("Generica");
            return asset.controlSchemes[m_GenericaSchemeIndex];
        }
    }
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface ICanonActions
    {
        void OnApuntar(InputAction.CallbackContext context);
        void OnDisparar(InputAction.CallbackContext context);
        void OnModificarFuerza(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
