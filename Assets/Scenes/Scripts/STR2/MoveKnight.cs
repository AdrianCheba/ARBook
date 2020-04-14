using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveKnight : MonoBehaviour
{
    Animator animator;
    public Button btnPowrot;
    int j;
    int flaga = 0;
    Vector3 orgPos;


    void Start()
    {

        animator = gameObject.GetComponent<Animator>();
        orgPos = transform.localPosition;
        btnPowrot = btnPowrot.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                j = 1;

                if (flaga == 0)
                {
                    animator.SetTrigger("Walk");
                    animator.ResetTrigger("powrot");
                    flaga = 1;

                }

            }
        }
                transform.Translate(new Vector3(0, 0, j) * Time.deltaTime);

    }

    public void Powrot()
    {
        animator.ResetTrigger("Walk");
        animator.SetTrigger("powrot");
        transform.localPosition = orgPos;
        j = 0;
        flaga = 0;

    }
}
