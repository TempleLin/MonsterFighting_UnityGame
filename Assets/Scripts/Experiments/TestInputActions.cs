// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Experiments/TestInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @TestInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @TestInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TestInputActions"",
    ""maps"": [
        {
            ""name"": ""TestMap"",
            ""id"": ""5b4067b7-6010-4244-971d-b3acc0f7c323"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""87f0ab12-da12-4a3a-a990-be05d9690ee2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""6f377692-d879-45ae-8e9a-f4aed81165c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f58a3c66-0cae-4c3a-b617-059eb2b75be4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5641a903-8305-4bff-9ea7-f50fa8323ed7"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TestMap
        m_TestMap = asset.FindActionMap("TestMap", throwIfNotFound: true);
        m_TestMap_Jump = m_TestMap.FindAction("Jump", throwIfNotFound: true);
        m_TestMap_Run = m_TestMap.FindAction("Run", throwIfNotFound: true);
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

    // TestMap
    private readonly InputActionMap m_TestMap;
    private ITestMapActions m_TestMapActionsCallbackInterface;
    private readonly InputAction m_TestMap_Jump;
    private readonly InputAction m_TestMap_Run;
    public struct TestMapActions
    {
        private @TestInputActions m_Wrapper;
        public TestMapActions(@TestInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_TestMap_Jump;
        public InputAction @Run => m_Wrapper.m_TestMap_Run;
        public InputActionMap Get() { return m_Wrapper.m_TestMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestMapActions set) { return set.Get(); }
        public void SetCallbacks(ITestMapActions instance)
        {
            if (m_Wrapper.m_TestMapActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_TestMapActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_TestMapActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_TestMapActionsCallbackInterface.OnJump;
                @Run.started -= m_Wrapper.m_TestMapActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_TestMapActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_TestMapActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_TestMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public TestMapActions @TestMap => new TestMapActions(this);
    public interface ITestMapActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
}
