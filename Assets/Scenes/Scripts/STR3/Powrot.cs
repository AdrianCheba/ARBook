using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Powrot : MonoBehaviour
{
    public Button btnPowrot;
    Animator anim;
    void Start()
    {

        btnPowrot = btnPowrot.GetComponent<Button>();
        anim = gameObject.GetComponent<Animator>();
    }

    public void btnPowrotF()
    {
        anim.ResetTrigger("Die");
        anim.SetTrigger("Reset");
        btnPowrot.enabled = true;
    }

}
