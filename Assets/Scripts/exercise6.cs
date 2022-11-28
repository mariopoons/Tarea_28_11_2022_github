using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise6 : MonoBehaviour
{
    public int num1;
    public int num2;

    private void Start()
    {
        IsLarger(num1, num2);
    }

    private int IsLarger(int num1, int num2)
    {
        if (num1 > num2)
        {
            Debug.Log($"{num1} is larger");
            return num1;
        }
        else
        {
            Debug.Log($"{num2} is larger");
            return num2;
        }   
    
    
    }
}
