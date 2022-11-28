using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise10 : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GoingUp();
        }
    }

    private void GoingUp()
    {
        transform.localScale += Vector3.one;
    }
}
