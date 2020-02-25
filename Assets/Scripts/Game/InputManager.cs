using System;
using Controls;
using UnityEngine;

namespace Game
{
    public enum ControllerConfig
    {
        Racing
    }

    public class InputManager : MonoBehaviour
    {
        private Controller _controller;


        private ControllerConfig _controllerConfig;

        private PolledInput _polledInput;

        private void Awake()
        {
            _polledInput = new PolledInput();
        }

        private void FixedUpdate()
        {
            switch (_controllerConfig)
            {
                case ControllerConfig.Racing:
                    _polledInput.leftStick = _controller.Racing.Steering.ReadValue<Vector2>();
                    _polledInput.buttonSouth = _controller.Racing.Accelerate.ReadValue<float>() > 0.5f;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            GameManager.GameManagerRef.SendInput(ref _polledInput);
        }
    }
}