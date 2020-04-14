using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    Vector3 orgPos;

    void Start()
    {
        orgPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("Wall"))
        {
            transform.localPosition = orgPos;
        }
    }

}
