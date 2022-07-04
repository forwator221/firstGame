//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerControls.inputactions
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
            ""name"": ""Player Movement"",
            ""id"": ""76f6356f-e713-4b7f-a1b4-60bc48f7715b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f030dc4d-f58e-428e-a388-f8916a06f1c5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bc2d8258-8152-4e15-99f5-7225a2d4afad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""cc5c5681-2f13-48b8-b9a4-ee919640b9c3"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d27615dd-9f42-4302-a71d-bd3ddf7473cf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a5e70c0d-305c-49a0-8c59-233bacd9b6b3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2f824624-5c4c-410f-8fd2-048e9f79a896"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2e5785dc-1a9c-446c-b665-bdc2d7c75f86"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Stick"",
                    ""id"": ""24c58371-f5f9-40e7-bf58-6503f777206d"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0836d193-5c3f-4dc9-b44c-8d80b9784155"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ad2d27bd-1133-4a2a-8608-268b9edc0944"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2f9df4d-42cf-4a3b-85d1-7ed6f9a1517c"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7df7c132-4394-4817-b518-ad250645b713"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""adcb8105-d32f-4ddb-8055-b03e2aff8ce6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Right Stick"",
                    ""id"": ""32ba0acc-835f-49e3-81e5-46afadeed221"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""290a6614-0f57-48f6-bfb7-15de9e7bb30a"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f467017d-11cb-4f59-aa86-bca2185b3154"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b38ccaa4-30f9-4248-9763-052942a90715"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""02a236ae-67c4-4074-a85d-551fea3ff062"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Player Actions"",
            ""id"": ""630e0eae-eacc-40df-9907-586e412a8865"",
            ""actions"": [
                {
                    ""name"": ""Sprinting"",
                    ""type"": ""Button"",
                    ""id"": ""967456ea-7005-40a4-a535-b8cb1ab3b649"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jumping"",
                    ""type"": ""Button"",
                    ""id"": ""00902782-4dcc-4f68-9301-169db0d7c65b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DodgeBackward"",
                    ""type"": ""Button"",
                    ""id"": ""f91539ac-414e-43fc-bf1d-96dc0f81540d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e3ef0283-3382-4e7c-99eb-4b31ec7ebad1"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprinting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78d8b897-b7ca-4eb6-93f9-000952c8ce52"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d4827074-b650-4c90-b419-5ad40b7038ff"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DodgeBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PauseGame"",
            ""id"": ""64d91e7b-0f35-4888-a911-a5d6a3857453"",
            ""actions"": [
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""7d42acff-cda1-4452-a493-3ed827e53076"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a4fed5c3-7b0f-4bde-a338-6d0beb149259"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Camera = m_PlayerMovement.FindAction("Camera", throwIfNotFound: true);
        // Player Actions
        m_PlayerActions = asset.FindActionMap("Player Actions", throwIfNotFound: true);
        m_PlayerActions_Sprinting = m_PlayerActions.FindAction("Sprinting", throwIfNotFound: true);
        m_PlayerActions_Jumping = m_PlayerActions.FindAction("Jumping", throwIfNotFound: true);
        m_PlayerActions_DodgeBackward = m_PlayerActions.FindAction("DodgeBackward", throwIfNotFound: true);
        // PauseGame
        m_PauseGame = asset.FindActionMap("PauseGame", throwIfNotFound: true);
        m_PauseGame_Pause = m_PauseGame.FindAction("Pause", throwIfNotFound: true);
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

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Camera;
    public struct PlayerMovementActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Camera => m_Wrapper.m_PlayerMovement_Camera;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Camera.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnCamera;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // Player Actions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Sprinting;
    private readonly InputAction m_PlayerActions_Jumping;
    private readonly InputAction m_PlayerActions_DodgeBackward;
    public struct PlayerActionsActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Sprinting => m_Wrapper.m_PlayerActions_Sprinting;
        public InputAction @Jumping => m_Wrapper.m_PlayerActions_Jumping;
        public InputAction @DodgeBackward => m_Wrapper.m_PlayerActions_DodgeBackward;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Sprinting.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSprinting;
                @Sprinting.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSprinting;
                @Sprinting.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSprinting;
                @Jumping.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJumping;
                @Jumping.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJumping;
                @Jumping.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnJumping;
                @DodgeBackward.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnDodgeBackward;
                @DodgeBackward.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnDodgeBackward;
                @DodgeBackward.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnDodgeBackward;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Sprinting.started += instance.OnSprinting;
                @Sprinting.performed += instance.OnSprinting;
                @Sprinting.canceled += instance.OnSprinting;
                @Jumping.started += instance.OnJumping;
                @Jumping.performed += instance.OnJumping;
                @Jumping.canceled += instance.OnJumping;
                @DodgeBackward.started += instance.OnDodgeBackward;
                @DodgeBackward.performed += instance.OnDodgeBackward;
                @DodgeBackward.canceled += instance.OnDodgeBackward;
            }
        }
    }
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);

    // PauseGame
    private readonly InputActionMap m_PauseGame;
    private IPauseGameActions m_PauseGameActionsCallbackInterface;
    private readonly InputAction m_PauseGame_Pause;
    public struct PauseGameActions
    {
        private @PlayerControls m_Wrapper;
        public PauseGameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Pause => m_Wrapper.m_PauseGame_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PauseGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PauseGameActions set) { return set.Get(); }
        public void SetCallbacks(IPauseGameActions instance)
        {
            if (m_Wrapper.m_PauseGameActionsCallbackInterface != null)
            {
                @Pause.started -= m_Wrapper.m_PauseGameActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PauseGameActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PauseGameActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PauseGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PauseGameActions @PauseGame => new PauseGameActions(this);
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnSprinting(InputAction.CallbackContext context);
        void OnJumping(InputAction.CallbackContext context);
        void OnDodgeBackward(InputAction.CallbackContext context);
    }
    public interface IPauseGameActions
    {
        void OnPause(InputAction.CallbackContext context);
    }
}
