using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Point : MonoBehaviour
{
    public int points = 0;

    private void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 500, 20), "Scroe: " + points);
    }
}