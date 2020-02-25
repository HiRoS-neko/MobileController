using System;
using System.Runtime.Serialization;
using UnityEngine;

namespace Controls
{
    [Serializable]
    public class PolledInput
    {
        public Vector2 leftStick;

        public bool buttonSouth, buttonEast, buttonNorth;
    }
}