//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputSystem/PlayerControls.inputactions
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

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""BasicMovement"",
            ""id"": ""9ce81923-5dc2-425f-b6e4-f4462cdd4fd4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4c777f52-f269-4764-9e81-c12c3d33bc1c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""8a57d47d-d769-45bf-9af4-bc65b8b3acf7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""ed828670-1a31-4087-b64f-95db323ffb0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f8727566-fb06-4ea6-abf5-7ae68d3b6226"",
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
                    ""id"": ""21bc3e32-7b97-4981-8dd7-415890fb36db"",
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
                    ""id"": ""6988a9e7-cfcf-4faf-a268-7d79f7b8e9e0"",
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
                    ""id"": ""d0800c3f-8c24-44c2-9c34-35bba2b057d5"",
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
                    ""id"": ""7bb7e44c-cb49-415a-968e-fba16f4b6ef8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""51b1e979-3097-4630-a507-e4b72ffad08f"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""798bcfe3-92c2-4a52-8e39-82e3797604f2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // BasicMovement
        m_BasicMovement = asset.FindActionMap("BasicMovement", throwIfNotFound: true);
        m_BasicMovement_Move = m_BasicMovement.FindAction("Move", throwIfNotFound: true);
        m_BasicMovement_Look = m_BasicMovement.FindAction("Look", throwIfNotFound: true);
        m_BasicMovement_Attack = m_BasicMovement.FindAction("Attack", throwIfNotFound: true);
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

    // BasicMovement
    private readonly InputActionMap m_BasicMovement;
    private IBasicMovementActions m_BasicMovementActionsCallbackInterface;
    private readonly InputAction m_BasicMovement_Move;
    private readonly InputAction m_BasicMovement_Look;
    private readonly InputAction m_BasicMovement_Attack;
    public struct BasicMovementActions
    {
        private @PlayerControls m_Wrapper;
        public BasicMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_BasicMovement_Move;
        public InputAction @Look => m_Wrapper.m_BasicMovement_Look;
        public InputAction @Attack => m_Wrapper.m_BasicMovement_Attack;
        public InputActionMap Get() { return m_Wrapper.m_BasicMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BasicMovementActions set) { return set.Get(); }
        public void SetCallbacks(IBasicMovementActions instance)
        {
            if (m_Wrapper.m_BasicMovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnLook;
                @Attack.started -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_BasicMovementActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_BasicMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public BasicMovementActions @BasicMovement => new BasicMovementActions(this);
    public interface IBasicMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}