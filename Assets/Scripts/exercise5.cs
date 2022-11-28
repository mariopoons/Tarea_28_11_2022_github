using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise5 : MonoBehaviour
{
    public int num1;


    private void Start()
    {
        table(num1);
    }

    private void table(int multiplo)
    {
        Debug.Log($"{multiplo * 1},{multiplo * 2},{multiplo * 3},{multiplo * 4},{multiplo * 5}," +
                  $"{multiplo*6}, {multiplo*7}, {multiplo * 8}, {multiplo * 9}, {multiplo * 10}");

    }


}
