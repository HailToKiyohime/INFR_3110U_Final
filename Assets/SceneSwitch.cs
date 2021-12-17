using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    private void Update()
    {
        if (FindObjectOfType<Point>().points > 10)
        {
            SceneManager.LoadScene("WinSence");
        }
    }
}