using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateKnight : MonoBehaviour
{
    int flaga = 0;

    private void Update()
    {
        if (flaga == 0)
        {
            if (transform.localPosition.x < -0.489f)
            {
                transform.Rotate(0, 180, 0);
                flaga = 1;
            }
        }
        else
        {
            if (transform.localPosition.x > 0.489f)
            {
                transform.Rotate(0, 180, 0);
                flaga = 0;
            }
        }


    }
}
