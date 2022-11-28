using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour
{
    public int num1;
    public int num2;

    private void Start()
    {
        Calculation(num1, num2);
    }

    private void Calculation(int hola,int adios)
    {
        if (hola / adios == 0)
        {
            Debug.Log("This divisor is exact!");
        }
        else
        {
            Debug.Log("This divisor is not exact!");
        }
    }

}
