/*
    * Madder class: MadderControllerState
    * This class is used to serialize the data sent to the PlayerControllerState function
    * This class defines the layout of the Madder Controller for the Unity Input System
    * This class should not be altered for the Madder controller
    */
#if USE_INPUT_SYSTEM
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.InputSystem.Layouts;
using UnityEngine;
[System.Serializable]
public struct MadderControllerState : IInputStateTypeInfo
{
    public static FourCC Format => new FourCC('M', 'A', 'D', 'R');
    public string name;
    [InputControl(name = "joystick", layout = "Vector2")]
    public Vector2 joystick;

    [InputControl(name = "circle", layout = "Button")]
    public bool circle;

    [InputControl(name = "triangle", layout = "Button")]
    public bool triangle;

    [InputControl(name = "plus", layout = "Button")]
    public bool plus;
    public FourCC format => Format;
}
#else
[System.Serializable]
public struct MadderControllerState
{
    public string name;
    public Vector2 joystick;
    public bool circle;
    public bool triangle;
    public bool plus;
}
#endif