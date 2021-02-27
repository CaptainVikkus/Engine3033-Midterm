// GENERATED AUTOMATICALLY FROM 'Assets/ColorControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ColorControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ColorControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ColorControl"",
    ""maps"": [
        {
            ""name"": ""ColorChange"",
            ""id"": ""612351d8-f7b8-4f5c-9aa2-283341d282d5"",
            ""actions"": [
                {
                    ""name"": ""Wheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4347d315-375c-4118-95d7-c15a56b52316"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Red"",
                    ""type"": ""Button"",
                    ""id"": ""c97aafd1-c92e-4356-a17c-227bebbc877e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Green"",
                    ""type"": ""Button"",
                    ""id"": ""00243e91-d55c-4d2a-8b66-80d6125e0d27"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Blue"",
                    ""type"": ""Button"",
                    ""id"": ""7dd92fc3-a52b-4268-b16c-913c51ca78c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yellow"",
                    ""type"": ""Button"",
                    ""id"": ""9b0f315a-48e7-4afd-b572-cebcb62240f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Purple"",
                    ""type"": ""Button"",
                    ""id"": ""eb547155-3490-46c8-be37-bb0563e2e41f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cyan"",
                    ""type"": ""Button"",
                    ""id"": ""f34cc67f-8ceb-4b6c-a625-710b5b14d786"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9ab6c54f-9b65-4220-a38f-3a84013a1c7c"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Red"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b450962c-2737-4807-bb52-57d884970e1b"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Green"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""341756e9-7d4d-40da-b9c3-3609ed193400"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Wheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c3f17cb-5929-47ae-b066-a2ca9b573578"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Blue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00fed61a-f336-4518-8e2b-15c456749493"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yellow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9acf600-af60-4642-baeb-e2be9a6bee49"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Purple"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c93df1fa-019d-4733-8b4d-989bdde20efa"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cyan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ColorChange
        m_ColorChange = asset.FindActionMap("ColorChange", throwIfNotFound: true);
        m_ColorChange_Wheel = m_ColorChange.FindAction("Wheel", throwIfNotFound: true);
        m_ColorChange_Red = m_ColorChange.FindAction("Red", throwIfNotFound: true);
        m_ColorChange_Green = m_ColorChange.FindAction("Green", throwIfNotFound: true);
        m_ColorChange_Blue = m_ColorChange.FindAction("Blue", throwIfNotFound: true);
        m_ColorChange_Yellow = m_ColorChange.FindAction("Yellow", throwIfNotFound: true);
        m_ColorChange_Purple = m_ColorChange.FindAction("Purple", throwIfNotFound: true);
        m_ColorChange_Cyan = m_ColorChange.FindAction("Cyan", throwIfNotFound: true);
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

    // ColorChange
    private readonly InputActionMap m_ColorChange;
    private IColorChangeActions m_ColorChangeActionsCallbackInterface;
    private readonly InputAction m_ColorChange_Wheel;
    private readonly InputAction m_ColorChange_Red;
    private readonly InputAction m_ColorChange_Green;
    private readonly InputAction m_ColorChange_Blue;
    private readonly InputAction m_ColorChange_Yellow;
    private readonly InputAction m_ColorChange_Purple;
    private readonly InputAction m_ColorChange_Cyan;
    public struct ColorChangeActions
    {
        private @ColorControl m_Wrapper;
        public ColorChangeActions(@ColorControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Wheel => m_Wrapper.m_ColorChange_Wheel;
        public InputAction @Red => m_Wrapper.m_ColorChange_Red;
        public InputAction @Green => m_Wrapper.m_ColorChange_Green;
        public InputAction @Blue => m_Wrapper.m_ColorChange_Blue;
        public InputAction @Yellow => m_Wrapper.m_ColorChange_Yellow;
        public InputAction @Purple => m_Wrapper.m_ColorChange_Purple;
        public InputAction @Cyan => m_Wrapper.m_ColorChange_Cyan;
        public InputActionMap Get() { return m_Wrapper.m_ColorChange; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ColorChangeActions set) { return set.Get(); }
        public void SetCallbacks(IColorChangeActions instance)
        {
            if (m_Wrapper.m_ColorChangeActionsCallbackInterface != null)
            {
                @Wheel.started -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnWheel;
                @Wheel.performed -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnWheel;
                @Wheel.canceled -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnWheel;
                @Red.started -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnRed;
                @Red.performed -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnRed;
                @Red.canceled -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnRed;
                @Green.started -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnGreen;
                @Green.performed -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnGreen;
                @Green.canceled -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnGreen;
                @Blue.started -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnBlue;
                @Blue.performed -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnBlue;
                @Blue.canceled -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnBlue;
                @Yellow.started -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnYellow;
                @Yellow.performed -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnYellow;
                @Yellow.canceled -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnYellow;
                @Purple.started -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnPurple;
                @Purple.performed -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnPurple;
                @Purple.canceled -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnPurple;
                @Cyan.started -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnCyan;
                @Cyan.performed -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnCyan;
                @Cyan.canceled -= m_Wrapper.m_ColorChangeActionsCallbackInterface.OnCyan;
            }
            m_Wrapper.m_ColorChangeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Wheel.started += instance.OnWheel;
                @Wheel.performed += instance.OnWheel;
                @Wheel.canceled += instance.OnWheel;
                @Red.started += instance.OnRed;
                @Red.performed += instance.OnRed;
                @Red.canceled += instance.OnRed;
                @Green.started += instance.OnGreen;
                @Green.performed += instance.OnGreen;
                @Green.canceled += instance.OnGreen;
                @Blue.started += instance.OnBlue;
                @Blue.performed += instance.OnBlue;
                @Blue.canceled += instance.OnBlue;
                @Yellow.started += instance.OnYellow;
                @Yellow.performed += instance.OnYellow;
                @Yellow.canceled += instance.OnYellow;
                @Purple.started += instance.OnPurple;
                @Purple.performed += instance.OnPurple;
                @Purple.canceled += instance.OnPurple;
                @Cyan.started += instance.OnCyan;
                @Cyan.performed += instance.OnCyan;
                @Cyan.canceled += instance.OnCyan;
            }
        }
    }
    public ColorChangeActions @ColorChange => new ColorChangeActions(this);
    public interface IColorChangeActions
    {
        void OnWheel(InputAction.CallbackContext context);
        void OnRed(InputAction.CallbackContext context);
        void OnGreen(InputAction.CallbackContext context);
        void OnBlue(InputAction.CallbackContext context);
        void OnYellow(InputAction.CallbackContext context);
        void OnPurple(InputAction.CallbackContext context);
        void OnCyan(InputAction.CallbackContext context);
    }
}
