using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise7 : MonoBehaviour
{
    public int num1;

    private void Start()
    {
        Absolute(num1);
    }

    private int Absolute(int num1)
    {
        if (num1 >= 0)
        {
            Debug.Log($"the absolute value is {num1}.");
            return num1;
        }
        else
        {
            Debug.Log($"the absolute value is {num1 * -1}.");
            return num1;
        }
    }
}
