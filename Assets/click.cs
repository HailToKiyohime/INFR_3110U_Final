using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
    public GameObject duck;
    private void OnMouseDown()
    {
        BasicPool.Instance.AddToPool(gameObject);
        FindObjectOfType<AudioManager>().Play("BridDie");
        FindObjectOfType<Point>().points++;
    }

    private void Awake()
    {
        EatSomeRamLikeARealGameObject();
    }

    int[] data;

    private void EatSomeRamLikeARealGameObject()
    {
        data = new int[1000];
        for (int i = 0; i < 1000; i++)
        {
            data[i] = i;
        }
    }
}
