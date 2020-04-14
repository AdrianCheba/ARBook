using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveDragon : MonoBehaviour
{
    Animator anim;
    Vector3 orgPos;
    
    public Image k1;
    public Image k2;
    public Image k3;
    public Image k4;
    public Image k5;
    public Image k6;
    public Text txt;
    public Button btnPij;
    public ParticleSystem pS;
    public AudioSource myAudioSource;
    

    int flaga = 0;
    int i = 1;
    int flaga2 = 1;
    int licznik = 0;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        btnPij = btnPij.GetComponent<Button>();
        orgPos = transform.localPosition;
        k1 = k1.GetComponent<Image>();
        k2 = k2.GetComponent<Image>();
        k3 = k3.GetComponent<Image>();
        k4 = k4.GetComponent<Image>();
        k5 = k5.GetComponent<Image>();
        k6 = k6.GetComponent<Image>();
        txt = txt.GetComponent<Text>();
        pS = pS.GetComponent<ParticleSystem>();
        myAudioSource = myAudioSource.GetComponent<AudioSource>();

        k1.enabled = true;
        k2.enabled = false;
        k3.enabled = false;
        k4.enabled = false;
        k5.enabled = false;
        k6.enabled = false;
        txt.enabled = false;
        btnPij.interactable = false;
        pS.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);

    }

    void Update()
    {
        for (int t = 0; t < Input.touchCount; t++)
        {
            if (Input.GetTouch(t).phase == TouchPhase.Began)
            {
                if (flaga2 == 0) {
                    anim.ResetTrigger("Pij");
                    anim.ResetTrigger("powrot");
                    anim.SetTrigger("move");
                    i = 1;
                    flaga2 = 1;
                    
                }
            }
        }
                transform.Translate(new Vector3(0, 0, i) * Time.deltaTime);
        if(flaga == 0)
        {
            anim.SetTrigger("move");
            flaga = 1;
                           
        }

        if(transform.localPosition.x < -0.080)
        {
            i = 0;
            anim.SetTrigger("powrot");
            anim.ResetTrigger("move");
            btnPij.interactable = true;
        }
        

    }

    public void Pij()
    {
        if (btnPij.interactable == true)
        {
            anim.ResetTrigger("powrot");
            anim.SetTrigger("pij");
            licznik += 1;

            if (licznik == 1)
            {
                k1.enabled = false;
                k2.enabled = true;
            }
            else if (licznik == 2)
            {
                k2.enabled = false;
                k3.enabled = true;
            }
            else if (licznik == 3)
            {
                k3.enabled = false;
                k4.enabled = true;
            }
            else if (licznik == 4)
            {
                k4.enabled = false;
                k5.enabled = true;
            }
            else if (licznik == 5)
            {
                k5.enabled = false;
                k6.enabled = true;
            }
            else if (licznik == 6)
            {
                k6.enabled = false;
                txt.enabled = true;
                myAudioSource.Play();
                gameObject.SetActive(false);
                pS.Play(true);
            }
        }
    }

    public void Powrot()
    {
        i = 0;
        licznik = 0;
        flaga2 = 0;
        k1.enabled = true;
        k2.enabled = false;
        k3.enabled = false;
        k4.enabled = false;
        k5.enabled = false;
        k6.enabled = false;
        txt.enabled = false;
        anim.ResetTrigger("Pij");
        anim.ResetTrigger("move");
        anim.SetTrigger("powrot");
        gameObject.SetActive(true);
        transform.localPosition = orgPos;
        btnPij.interactable = false;
     
    }
}
