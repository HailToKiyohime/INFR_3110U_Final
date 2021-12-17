using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float RandSound = Random.Range(1, 4);
            if (RandSound == 1)
            {
                FindObjectOfType<AudioManager>().Play("Gun1");
            }
            else if (RandSound == 2)
            {
                FindObjectOfType<AudioManager>().Play("Gun2");
            }
            else if (RandSound == 3)
            {
                FindObjectOfType<AudioManager>().Play("Gun3");
            }

        }
    }
}
