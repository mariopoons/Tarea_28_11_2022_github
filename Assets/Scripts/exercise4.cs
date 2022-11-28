using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise4 : MonoBehaviour
{
    public Vector3 up = new Vector3(0, 1, 0);
    

    private void Start()
    {
        Movement(up);
    }

    private void Movement(Vector3 up)
    {
        transform.position = up;
    }
}
