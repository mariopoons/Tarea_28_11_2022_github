using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise9 : MonoBehaviour
{
    public int basex;
    public int heighty;

    private void Start()
    {
        Area(basex, heighty);
    }

    private void Area(int num1, int num2)
    {
        if (num1 > 0 && num2 > 0)
        {
            Debug.Log($"The area of the trangle is {num1 * num2 / 2}");
        }
        else
        {
            Debug.Log($"The area of the triangles is not calculable");
        }
    }
}
