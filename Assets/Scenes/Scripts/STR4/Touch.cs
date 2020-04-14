using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class Touch : MonoBehaviour
{
    public AudioClip aClips;
    public AudioSource myAudioSource;
    Animator anim;
    string btnName;

    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        anim = gameObject.GetComponent<Animator>();

    }

    private void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;

            if(Physics.Raycast(ray, out Hit)){
                btnName = Hit.transform.name;

                switch (btnName)
                {
                    case "element1":
                        myAudioSource.clip = aClips;
                        myAudioSource.Play();
                        anim.SetTrigger("anim");
                        break;
                    case "element2":
                        myAudioSource.clip = aClips;
                        myAudioSource.Play();
                        anim.SetTrigger("anim2");
                        break;
                    case "element3":
                        myAudioSource.clip = aClips;
                        myAudioSource.Play();
                        anim.SetTrigger("anim3");
                        break;
                    case "element4":
                        myAudioSource.clip = aClips;
                        myAudioSource.Play();
                        anim.SetTrigger("anim4");
                        break;
                    default:
                        break;
                }

            }
        }
    }

    public void Powrot()
    {
        anim.ResetTrigger("anim");
        anim.ResetTrigger("anim2");
        anim.ResetTrigger("anim3");
        anim.ResetTrigger("anim4");
        anim.SetTrigger("powrot");
    }


}