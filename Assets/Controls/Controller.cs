// GENERATED AUTOMATICALLY FROM 'Assets/Controls/Controller.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Controls
{
    public class @Controller : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controller()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controller"",
    ""maps"": [
        {
            ""name"": ""Racing"",
            ""id"": ""1ede5b9f-f2d0-4638-9e30-1b6f3d19232c"",
            ""actions"": [
                {
                    ""name"": ""Steering"",
                    ""type"": ""Value"",
                    ""id"": ""1fcb1e47-9362-4b9c-aea0-da68ecc27785"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""d76ea44a-16f3-488b-8382-55e11008899b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""ba5a8b01-ac59-4c56-9f98-23e19cd5a4f3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Drift"",
                    ""type"": ""Button"",
                    ""id"": ""4e9a840f-b27a-42b1-a7dd-c63d6cb0329a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""591b5676-1a0c-4a13-b7f9-97ceb71c810f"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7eb45b9f-7886-42c1-b450-3af3e15ca8f5"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steering"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""03746ee6-bab4-4f80-aff1-be904531286e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85923482-03c5-4e9f-80f7-a86d16095d2b"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8edca0b4-f17e-4cb6-9c02-a19bca8dd42d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebf57658-a98c-4a51-aac6-24195ad429c4"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1220de3f-accc-4d5e-978b-23f0a32c00c1"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ef1c568-6cd3-4741-a4ef-304941d4c6de"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Racing
            m_Racing = asset.FindActionMap("Racing", throwIfNotFound: true);
            m_Racing_Steering = m_Racing.FindAction("Steering", throwIfNotFound: true);
            m_Racing_Accelerate = m_Racing.FindAction("Accelerate", throwIfNotFound: true);
            m_Racing_Brake = m_Racing.FindAction("Brake", throwIfNotFound: true);
            m_Racing_Drift = m_Racing.FindAction("Drift", throwIfNotFound: true);
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

        // Racing
        private readonly InputActionMap m_Racing;
        private IRacingActions m_RacingActionsCallbackInterface;
        private readonly InputAction m_Racing_Steering;
        private readonly InputAction m_Racing_Accelerate;
        private readonly InputAction m_Racing_Brake;
        private readonly InputAction m_Racing_Drift;
        public struct RacingActions
        {
            private @Controller m_Wrapper;
            public RacingActions(@Controller wrapper) { m_Wrapper = wrapper; }
            public InputAction @Steering => m_Wrapper.m_Racing_Steering;
            public InputAction @Accelerate => m_Wrapper.m_Racing_Accelerate;
            public InputAction @Brake => m_Wrapper.m_Racing_Brake;
            public InputAction @Drift => m_Wrapper.m_Racing_Drift;
            public InputActionMap Get() { return m_Wrapper.m_Racing; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RacingActions set) { return set.Get(); }
            public void SetCallbacks(IRacingActions instance)
            {
                if (m_Wrapper.m_RacingActionsCallbackInterface != null)
                {
                    @Steering.started -= m_Wrapper.m_RacingActionsCallbackInterface.OnSteering;
                    @Steering.performed -= m_Wrapper.m_RacingActionsCallbackInterface.OnSteering;
                    @Steering.canceled -= m_Wrapper.m_RacingActionsCallbackInterface.OnSteering;
                    @Accelerate.started -= m_Wrapper.m_RacingActionsCallbackInterface.OnAccelerate;
                    @Accelerate.performed -= m_Wrapper.m_RacingActionsCallbackInterface.OnAccelerate;
                    @Accelerate.canceled -= m_Wrapper.m_RacingActionsCallbackInterface.OnAccelerate;
                    @Brake.started -= m_Wrapper.m_RacingActionsCallbackInterface.OnBrake;
                    @Brake.performed -= m_Wrapper.m_RacingActionsCallbackInterface.OnBrake;
                    @Brake.canceled -= m_Wrapper.m_RacingActionsCallbackInterface.OnBrake;
                    @Drift.started -= m_Wrapper.m_RacingActionsCallbackInterface.OnDrift;
                    @Drift.performed -= m_Wrapper.m_RacingActionsCallbackInterface.OnDrift;
                    @Drift.canceled -= m_Wrapper.m_RacingActionsCallbackInterface.OnDrift;
                }
                m_Wrapper.m_RacingActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Steering.started += instance.OnSteering;
                    @Steering.performed += instance.OnSteering;
                    @Steering.canceled += instance.OnSteering;
                    @Accelerate.started += instance.OnAccelerate;
                    @Accelerate.performed += instance.OnAccelerate;
                    @Accelerate.canceled += instance.OnAccelerate;
                    @Brake.started += instance.OnBrake;
                    @Brake.performed += instance.OnBrake;
                    @Brake.canceled += instance.OnBrake;
                    @Drift.started += instance.OnDrift;
                    @Drift.performed += instance.OnDrift;
                    @Drift.canceled += instance.OnDrift;
                }
            }
        }
        public RacingActions @Racing => new RacingActions(this);
        public interface IRacingActions
        {
            void OnSteering(InputAction.CallbackContext context);
            void OnAccelerate(InputAction.CallbackContext context);
            void OnBrake(InputAction.CallbackContext context);
            void OnDrift(InputAction.CallbackContext context);
        }
    }
}
