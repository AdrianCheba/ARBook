using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDragon2 : MonoBehaviour
{
    public Animator animator;
    public int flaga = 0;
    public float i = 0.5f;
    
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        transform.Translate(new Vector3(0, 0, i) * Time.deltaTime);
        if (flaga == 0)
        {
            animator.ResetTrigger("powrot");
            animator.SetTrigger("move");
            flaga = 1;
        }
    }

    private void OnTriggerEnter(Collider collide)
    {
        if(collide.gameObject.CompareTag("Wall"))
        {
            animator.ResetTrigger("move");
            animator.SetTrigger("powrot");
            i = 0;
        }
    }
}
