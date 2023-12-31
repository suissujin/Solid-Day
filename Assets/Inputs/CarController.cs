//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs/CarController.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @CarController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CarController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""CarController"",
    ""maps"": [
        {
            ""name"": ""CarControlls"",
            ""id"": ""bb3270e7-46e1-42a3-a1e1-f615d3848f97"",
            ""actions"": [
                {
                    ""name"": ""accelerate"",
                    ""type"": ""Value"",
                    ""id"": ""5865f7bd-182c-4b43-b8cb-5fc01a719190"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""frontSteering"",
                    ""type"": ""Value"",
                    ""id"": ""8d6411b9-ba84-46a3-9af4-5211ce956f19"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""rearSteering"",
                    ""type"": ""Value"",
                    ""id"": ""07349e4c-4142-4f64-be06-f2983ffe4081"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""brake"",
                    ""type"": ""Value"",
                    ""id"": ""a1ab5b3d-6679-4a69-90b1-2f827e38e605"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""backingUp"",
                    ""type"": ""Value"",
                    ""id"": ""8c2c7ce4-bec5-4906-844f-2bf66db49da0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SwitchCar1"",
                    ""type"": ""Button"",
                    ""id"": ""f7c8c53f-599e-4a1d-87bd-465274e86f2e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchCar2"",
                    ""type"": ""Button"",
                    ""id"": ""58aa5b95-0add-4e7b-a997-54bc56f08f66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchCar3"",
                    ""type"": ""Button"",
                    ""id"": ""81068ce5-a6f8-486c-97c4-df23325a6dbd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchCar4"",
                    ""type"": ""Button"",
                    ""id"": ""fd8b92e0-9523-48bd-823b-64b32b4c0c38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""47daef9c-5d75-467c-8fb1-94ed54f84461"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ResetCar"",
                    ""type"": ""Button"",
                    ""id"": ""76937db6-c95e-4829-9cd4-c5b8f01f1e37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""QuitGame"",
                    ""type"": ""Button"",
                    ""id"": ""82f3966f-cbee-46c6-89bc-c1c45789af26"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b163bfae-c98a-4786-b0bd-8c142d315598"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4248fc8-f016-4049-b31e-2237f20f62b0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c105a2f-5f6b-4f0d-9a81-5af645159f5a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4947d4bf-51c8-4fd8-8b5b-165e1a22780a"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""frontSteering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""7bba91ad-6fec-4abf-a308-5dc4b5d28086"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""frontSteering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""d3e1ac03-5c90-4637-9c04-a933ce421252"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""frontSteering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""85cadef0-c011-447a-aa3f-e08bdfaa70af"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""frontSteering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9c242315-7e3e-4ae9-afd5-094444eecbe3"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rearSteering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""0da7e9ae-213b-4543-8e04-dee51554cdd2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rearSteering"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2a4e98a9-8cd8-488d-9ed8-665c4a5a07e7"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rearSteering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a9d9d163-d98a-4ebc-874e-57c66ee41097"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rearSteering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b4c54087-45a2-409a-a677-2381d6eab08d"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1aeaf9f5-586f-453d-ab54-c47489eb283b"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22fc5791-4662-49f0-9832-8c358b6d5a7d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ea6a3b1-4d2b-4675-81fe-19baa4be170b"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""backingUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5d5f668-30f9-46cd-988c-7ec154661029"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""backingUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""07591de4-a582-4de8-b3b3-ecacc6a71715"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCar1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f928d993-ba4d-40d9-a961-cb00793e5baf"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCar1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a846e010-fd10-4fa0-adc6-cc457d8170d1"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCar2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6668053-ac0a-4bf6-b393-a40c9d8c067a"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCar2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b1d8e10-aa68-42c6-ba53-31adb544cd3d"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCar3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3fc8abb-ae38-4bbe-9221-148f3cfbea75"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCar3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f75a305-8f7a-41c0-8f30-02db33d50b80"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCar4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaae7bbb-2459-4159-93bc-b5dabf13ae9a"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchCar4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""185f7537-950c-41d6-8d56-35b65256beab"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9845276-8647-4918-bfc0-bc79e365a811"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf282cd1-cd40-427b-8447-ba0af4ced407"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdd58a9f-7ea2-4a3a-8cae-e00d2e19143b"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ResetCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36a915ae-18d7-48f3-afb3-8daced258a3c"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfbff57d-a51a-4494-814e-d4ba443bce52"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuitGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CarControlls
        m_CarControlls = asset.FindActionMap("CarControlls", throwIfNotFound: true);
        m_CarControlls_accelerate = m_CarControlls.FindAction("accelerate", throwIfNotFound: true);
        m_CarControlls_frontSteering = m_CarControlls.FindAction("frontSteering", throwIfNotFound: true);
        m_CarControlls_rearSteering = m_CarControlls.FindAction("rearSteering", throwIfNotFound: true);
        m_CarControlls_brake = m_CarControlls.FindAction("brake", throwIfNotFound: true);
        m_CarControlls_backingUp = m_CarControlls.FindAction("backingUp", throwIfNotFound: true);
        m_CarControlls_SwitchCar1 = m_CarControlls.FindAction("SwitchCar1", throwIfNotFound: true);
        m_CarControlls_SwitchCar2 = m_CarControlls.FindAction("SwitchCar2", throwIfNotFound: true);
        m_CarControlls_SwitchCar3 = m_CarControlls.FindAction("SwitchCar3", throwIfNotFound: true);
        m_CarControlls_SwitchCar4 = m_CarControlls.FindAction("SwitchCar4", throwIfNotFound: true);
        m_CarControlls_Pause = m_CarControlls.FindAction("Pause", throwIfNotFound: true);
        m_CarControlls_ResetCar = m_CarControlls.FindAction("ResetCar", throwIfNotFound: true);
        m_CarControlls_QuitGame = m_CarControlls.FindAction("QuitGame", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // CarControlls
    private readonly InputActionMap m_CarControlls;
    private List<ICarControllsActions> m_CarControllsActionsCallbackInterfaces = new List<ICarControllsActions>();
    private readonly InputAction m_CarControlls_accelerate;
    private readonly InputAction m_CarControlls_frontSteering;
    private readonly InputAction m_CarControlls_rearSteering;
    private readonly InputAction m_CarControlls_brake;
    private readonly InputAction m_CarControlls_backingUp;
    private readonly InputAction m_CarControlls_SwitchCar1;
    private readonly InputAction m_CarControlls_SwitchCar2;
    private readonly InputAction m_CarControlls_SwitchCar3;
    private readonly InputAction m_CarControlls_SwitchCar4;
    private readonly InputAction m_CarControlls_Pause;
    private readonly InputAction m_CarControlls_ResetCar;
    private readonly InputAction m_CarControlls_QuitGame;
    public struct CarControllsActions
    {
        private @CarController m_Wrapper;
        public CarControllsActions(@CarController wrapper) { m_Wrapper = wrapper; }
        public InputAction @accelerate => m_Wrapper.m_CarControlls_accelerate;
        public InputAction @frontSteering => m_Wrapper.m_CarControlls_frontSteering;
        public InputAction @rearSteering => m_Wrapper.m_CarControlls_rearSteering;
        public InputAction @brake => m_Wrapper.m_CarControlls_brake;
        public InputAction @backingUp => m_Wrapper.m_CarControlls_backingUp;
        public InputAction @SwitchCar1 => m_Wrapper.m_CarControlls_SwitchCar1;
        public InputAction @SwitchCar2 => m_Wrapper.m_CarControlls_SwitchCar2;
        public InputAction @SwitchCar3 => m_Wrapper.m_CarControlls_SwitchCar3;
        public InputAction @SwitchCar4 => m_Wrapper.m_CarControlls_SwitchCar4;
        public InputAction @Pause => m_Wrapper.m_CarControlls_Pause;
        public InputAction @ResetCar => m_Wrapper.m_CarControlls_ResetCar;
        public InputAction @QuitGame => m_Wrapper.m_CarControlls_QuitGame;
        public InputActionMap Get() { return m_Wrapper.m_CarControlls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CarControllsActions set) { return set.Get(); }
        public void AddCallbacks(ICarControllsActions instance)
        {
            if (instance == null || m_Wrapper.m_CarControllsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CarControllsActionsCallbackInterfaces.Add(instance);
            @accelerate.started += instance.OnAccelerate;
            @accelerate.performed += instance.OnAccelerate;
            @accelerate.canceled += instance.OnAccelerate;
            @frontSteering.started += instance.OnFrontSteering;
            @frontSteering.performed += instance.OnFrontSteering;
            @frontSteering.canceled += instance.OnFrontSteering;
            @rearSteering.started += instance.OnRearSteering;
            @rearSteering.performed += instance.OnRearSteering;
            @rearSteering.canceled += instance.OnRearSteering;
            @brake.started += instance.OnBrake;
            @brake.performed += instance.OnBrake;
            @brake.canceled += instance.OnBrake;
            @backingUp.started += instance.OnBackingUp;
            @backingUp.performed += instance.OnBackingUp;
            @backingUp.canceled += instance.OnBackingUp;
            @SwitchCar1.started += instance.OnSwitchCar1;
            @SwitchCar1.performed += instance.OnSwitchCar1;
            @SwitchCar1.canceled += instance.OnSwitchCar1;
            @SwitchCar2.started += instance.OnSwitchCar2;
            @SwitchCar2.performed += instance.OnSwitchCar2;
            @SwitchCar2.canceled += instance.OnSwitchCar2;
            @SwitchCar3.started += instance.OnSwitchCar3;
            @SwitchCar3.performed += instance.OnSwitchCar3;
            @SwitchCar3.canceled += instance.OnSwitchCar3;
            @SwitchCar4.started += instance.OnSwitchCar4;
            @SwitchCar4.performed += instance.OnSwitchCar4;
            @SwitchCar4.canceled += instance.OnSwitchCar4;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @ResetCar.started += instance.OnResetCar;
            @ResetCar.performed += instance.OnResetCar;
            @ResetCar.canceled += instance.OnResetCar;
            @QuitGame.started += instance.OnQuitGame;
            @QuitGame.performed += instance.OnQuitGame;
            @QuitGame.canceled += instance.OnQuitGame;
        }

        private void UnregisterCallbacks(ICarControllsActions instance)
        {
            @accelerate.started -= instance.OnAccelerate;
            @accelerate.performed -= instance.OnAccelerate;
            @accelerate.canceled -= instance.OnAccelerate;
            @frontSteering.started -= instance.OnFrontSteering;
            @frontSteering.performed -= instance.OnFrontSteering;
            @frontSteering.canceled -= instance.OnFrontSteering;
            @rearSteering.started -= instance.OnRearSteering;
            @rearSteering.performed -= instance.OnRearSteering;
            @rearSteering.canceled -= instance.OnRearSteering;
            @brake.started -= instance.OnBrake;
            @brake.performed -= instance.OnBrake;
            @brake.canceled -= instance.OnBrake;
            @backingUp.started -= instance.OnBackingUp;
            @backingUp.performed -= instance.OnBackingUp;
            @backingUp.canceled -= instance.OnBackingUp;
            @SwitchCar1.started -= instance.OnSwitchCar1;
            @SwitchCar1.performed -= instance.OnSwitchCar1;
            @SwitchCar1.canceled -= instance.OnSwitchCar1;
            @SwitchCar2.started -= instance.OnSwitchCar2;
            @SwitchCar2.performed -= instance.OnSwitchCar2;
            @SwitchCar2.canceled -= instance.OnSwitchCar2;
            @SwitchCar3.started -= instance.OnSwitchCar3;
            @SwitchCar3.performed -= instance.OnSwitchCar3;
            @SwitchCar3.canceled -= instance.OnSwitchCar3;
            @SwitchCar4.started -= instance.OnSwitchCar4;
            @SwitchCar4.performed -= instance.OnSwitchCar4;
            @SwitchCar4.canceled -= instance.OnSwitchCar4;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @ResetCar.started -= instance.OnResetCar;
            @ResetCar.performed -= instance.OnResetCar;
            @ResetCar.canceled -= instance.OnResetCar;
            @QuitGame.started -= instance.OnQuitGame;
            @QuitGame.performed -= instance.OnQuitGame;
            @QuitGame.canceled -= instance.OnQuitGame;
        }

        public void RemoveCallbacks(ICarControllsActions instance)
        {
            if (m_Wrapper.m_CarControllsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICarControllsActions instance)
        {
            foreach (var item in m_Wrapper.m_CarControllsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CarControllsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CarControllsActions @CarControlls => new CarControllsActions(this);
    public interface ICarControllsActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnFrontSteering(InputAction.CallbackContext context);
        void OnRearSteering(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnBackingUp(InputAction.CallbackContext context);
        void OnSwitchCar1(InputAction.CallbackContext context);
        void OnSwitchCar2(InputAction.CallbackContext context);
        void OnSwitchCar3(InputAction.CallbackContext context);
        void OnSwitchCar4(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnResetCar(InputAction.CallbackContext context);
        void OnQuitGame(InputAction.CallbackContext context);
    }
}
