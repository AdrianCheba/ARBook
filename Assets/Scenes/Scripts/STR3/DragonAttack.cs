using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragonAttack : MonoBehaviour 
{
    Animator anim;
    public Button btnAttack;
    public ParticleSystem ogien;
    int licznik = 0;
    AudioSource myAudioSource;


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        btnAttack = btnAttack.GetComponent<Button>();
        ogien = ogien.GetComponent<ParticleSystem>();
        ogien.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        myAudioSource = gameObject.GetComponent<AudioSource>();
        btnAttack.enabled = false;

    }


    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                btnAttack.enabled = true;
                btnAttack.enabled = isActiveAndEnabled;

            }
        }
    }

    public void AttackButton()
    {
        anim.SetTrigger("attack");
        ogien.Play(true);
        btnAttack.enabled = true;
        myAudioSource.Play();
    }
}
