using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class SimplePlugin : MonoBehaviour
{
    [DllImport("SwitchSound")]
    private static extern float Silencer();

    [DllImport("SwitchSound")]
    private static extern float SilencerPitch();

    private void Update()
    {

    }
}
