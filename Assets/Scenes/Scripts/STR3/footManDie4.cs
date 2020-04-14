﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class footManDie4 : MonoBehaviour
{
    public Button btnAttack;
    public Button btnPowrot;
    Animator anim;
    int flaga = 0;

    void Start()
    {
        btnAttack = btnAttack.GetComponent<Button>();
        btnPowrot = btnPowrot.GetComponent<Button>();
        anim = gameObject.GetComponent<Animator>();
        btnAttack.onClick.AddListener(FootManDie);
        btnPowrot.onClick.AddListener(Powrot);
    }


    public void FootManDie()
    {
        flaga += 1;
        if (flaga == 4)
        {
            anim.ResetTrigger("attack");
            anim.ResetTrigger("Reset");
            anim.SetTrigger("Die");
            flaga = 8;
        }
    }

    public void Powrot()
    {

        anim.ResetTrigger("Die");
        anim.SetTrigger("Reset");
        flaga = 0;
    }
}
