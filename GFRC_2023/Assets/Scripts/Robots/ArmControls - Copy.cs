//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/ArmControls.inputactions
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

public partial class @ArmControls: IInputActionCollection2, IDisposable
{
    /*public InputActionAsset asset { get; }
    public @ArmControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ArmControls"",
    ""maps"": [
        {
            ""name"": ""Arm"",
            ""id"": ""8ce42dc2-e730-4e0c-9bc3-39eb6a777b84"",
            ""actions"": [
                {
                    ""name"": ""MoveBaseForward"",
                    ""type"": ""Value"",
                    ""id"": ""8f0bf33f-0d8d-4418-a2a3-cf41bfa865b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.01,pressPoint=0.05)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveBaseBack"",
                    ""type"": ""Value"",
                    ""id"": ""352601e0-6c3a-40c4-b838-abc6a705e6bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.01,pressPoint=0.05)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveMidForward"",
                    ""type"": ""Value"",
                    ""id"": ""336fb40b-d249-4e7f-9981-08771cd5cb07"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.01,pressPoint=0.05)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveMidBack"",
                    ""type"": ""Value"",
                    ""id"": ""02c8a692-7e06-4334-aefc-110121d5d33a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.01,pressPoint=0.05)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""18c309a0-1cb4-49f8-a6e9-5d62fdd1ed9e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveBaseForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9e606dd-3b5a-451a-977f-b62211ebe96f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveBaseBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bca300a-a0a7-4c8f-8d87-deff19d80f82"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveMidForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d942f02-1009-43cd-9aec-352c1e8ac006"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveMidBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Arm
        m_Arm = asset.FindActionMap("Arm", throwIfNotFound: true);
        m_Arm_MoveBaseForward = m_Arm.FindAction("MoveBaseForward", throwIfNotFound: true);
        m_Arm_MoveBaseBack = m_Arm.FindAction("MoveBaseBack", throwIfNotFound: true);
        m_Arm_MoveMidForward = m_Arm.FindAction("MoveMidForward", throwIfNotFound: true);
        m_Arm_MoveMidBack = m_Arm.FindAction("MoveMidBack", throwIfNotFound: true);
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

    // Arm
    private readonly InputActionMap m_Arm;
    private List<IArmActions> m_ArmActionsCallbackInterfaces = new List<IArmActions>();
    private readonly InputAction m_Arm_MoveBaseForward;
    private readonly InputAction m_Arm_MoveBaseBack;
    private readonly InputAction m_Arm_MoveMidForward;
    private readonly InputAction m_Arm_MoveMidBack;
    public struct ArmActions
    {
        private @ArmControls m_Wrapper;
        public ArmActions(@ArmControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveBaseForward => m_Wrapper.m_Arm_MoveBaseForward;
        public InputAction @MoveBaseBack => m_Wrapper.m_Arm_MoveBaseBack;
        public InputAction @MoveMidForward => m_Wrapper.m_Arm_MoveMidForward;
        public InputAction @MoveMidBack => m_Wrapper.m_Arm_MoveMidBack;
        public InputActionMap Get() { return m_Wrapper.m_Arm; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ArmActions set) { return set.Get(); }
        public void AddCallbacks(IArmActions instance)
        {
            if (instance == null || m_Wrapper.m_ArmActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ArmActionsCallbackInterfaces.Add(instance);
            @MoveBaseForward.started += instance.OnMoveBaseForward;
            @MoveBaseForward.performed += instance.OnMoveBaseForward;
            @MoveBaseForward.canceled += instance.OnMoveBaseForward;
            @MoveBaseBack.started += instance.OnMoveBaseBack;
            @MoveBaseBack.performed += instance.OnMoveBaseBack;
            @MoveBaseBack.canceled += instance.OnMoveBaseBack;
            @MoveMidForward.started += instance.OnMoveMidForward;
            @MoveMidForward.performed += instance.OnMoveMidForward;
            @MoveMidForward.canceled += instance.OnMoveMidForward;
            @MoveMidBack.started += instance.OnMoveMidBack;
            @MoveMidBack.performed += instance.OnMoveMidBack;
            @MoveMidBack.canceled += instance.OnMoveMidBack;
        }

        private void UnregisterCallbacks(IArmActions instance)
        {
            @MoveBaseForward.started -= instance.OnMoveBaseForward;
            @MoveBaseForward.performed -= instance.OnMoveBaseForward;
            @MoveBaseForward.canceled -= instance.OnMoveBaseForward;
            @MoveBaseBack.started -= instance.OnMoveBaseBack;
            @MoveBaseBack.performed -= instance.OnMoveBaseBack;
            @MoveBaseBack.canceled -= instance.OnMoveBaseBack;
            @MoveMidForward.started -= instance.OnMoveMidForward;
            @MoveMidForward.performed -= instance.OnMoveMidForward;
            @MoveMidForward.canceled -= instance.OnMoveMidForward;
            @MoveMidBack.started -= instance.OnMoveMidBack;
            @MoveMidBack.performed -= instance.OnMoveMidBack;
            @MoveMidBack.canceled -= instance.OnMoveMidBack;
        }

        public void RemoveCallbacks(IArmActions instance)
        {
            if (m_Wrapper.m_ArmActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IArmActions instance)
        {
            foreach (var item in m_Wrapper.m_ArmActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ArmActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ArmActions @Arm => new ArmActions(this);
    public interface IArmActions
    {
        void OnMoveBaseForward(InputAction.CallbackContext context);
        void OnMoveBaseBack(InputAction.CallbackContext context);
        void OnMoveMidForward(InputAction.CallbackContext context);
        void OnMoveMidBack(InputAction.CallbackContext context);
    }*/
}
