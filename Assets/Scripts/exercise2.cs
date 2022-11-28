using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour
{
    public int number;

    private void Start()
    {
        isEven(number);
    }

    private bool isEven(int l)
    {
        if (l / 2 == 0) 
        {
            Debug.Log("This is a even");
            return true;

        }
        else
        {
            Debug.Log("This is not a even");
            return false;
        }
    }
}
