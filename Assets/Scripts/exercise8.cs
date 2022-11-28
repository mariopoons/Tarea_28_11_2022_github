using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise8 : MonoBehaviour
{
    public int year;

    private void Start()
    {
        LeapYear(year);
    }

    private int LeapYear(int leap)
    {
        if(leap % 4 == 0 && leap % 100 != 0 && leap % 400 == 0)
        {
            Debug.Log($"{leap} is a leap year.");
            return leap;
        }
        else if (leap % 4 == 0 && leap % 100 != 0 && leap % 400 != 0)
        {
            Debug.Log($"{leap} is a leap year.");
            return leap;
        }
        else if (leap % 4 == 0 && leap % 100 == 0 && leap % 400 == 0)
        {
            Debug.Log($"{leap} is a leap year.");
            return leap;
        }
        else
        {
            Debug.Log($"{leap} is a leap year.");
            return leap;
        }
    }
}
