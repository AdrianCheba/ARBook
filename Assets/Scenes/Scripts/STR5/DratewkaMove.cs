using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DratewkaMove : MonoBehaviour
{

    static public int licznik = 0;
    float j = 0.00075f;
    Animator anim;
    Vector3 orgPos;
    Vector3 orgPos2;
    Quaternion orgRot;
    GameObject ob1;
    GameObject ob2;
    int flaga = 0;
    int flaga2 = 0;
    public Text txt;
    public Button btnPowrot;
    MoveDragon2 skrypt;


    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        orgPos = transform.localPosition;
        ob1 = GameObject.FindGameObjectWithTag("sheep");
        ob2 = GameObject.FindGameObjectWithTag("dragon");
        orgPos2 = ob2.transform.localPosition;
        orgRot = transform.localRotation;
        btnPowrot = btnPowrot.GetComponent<Button>();
        skrypt = (MoveDragon2)ob2.GetComponent(typeof(MoveDragon2));

        ob1.SetActive(false);
        ob2.SetActive(false);

    }


    void Update()
    {
        for (int k = 0; k < Input.touchCount; k++)
        {
            if (Input.GetTouch(k).phase == TouchPhase.Began)
            {
                licznik += 1;
            }
        }

        if(licznik > 50)
        {
            if (flaga2 < 3)
            {
                if (flaga == 0)
                {
                    anim.SetTrigger("move");
                    anim.ResetTrigger("powrot");
                    flaga = 1;
                }
                transform.Translate(new Vector3(j, 0, 0) * Time.deltaTime);
            }
        }

        if(licznik > 125)
        {
            if (flaga2 < 3)
            {
                if (flaga == 1)
                {
                    anim.ResetTrigger("move");
                    anim.SetTrigger("run");
                    flaga = 2;
                }
                j = 0.002f;
            }
        }
        if (licznik < 125)
        {
            txt.text = "Poziom męstwa: " + licznik;
        }
        else if(licznik > 125)
        {
            txt.text = "Poziom męstwa: " + 125 + "+";
        }

    }


    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("Wall"))
        {
            transform.Rotate(0, 180, 0);
            ob1.SetActive(true);
            ob2.SetActive(true);
            flaga2 = 1;
        }
        
        if (flaga2 == 1)
        {
            if (collide.gameObject.CompareTag("Wall2"))
            {
                transform.Rotate(0, -90, 0);
                flaga2 = 2;
            }
        }
        
        if (collide.gameObject.CompareTag("Wall3"))
        {
            transform.Rotate(0, 180, 0);
            flaga2 = 3;
            anim.ResetTrigger("move");
            anim.ResetTrigger("run");
            anim.SetTrigger("powrot");
        }
    }

   public void Powrot()
   {
        flaga = 0;
        flaga2 = 0;
        licznik = 0;
        j = 0.00075f;
        
        gameObject.transform.localPosition = orgPos;
        ob2.transform.localPosition = orgPos2;
        transform.localRotation = orgRot;
        ob1.SetActive(false);
        ob2.SetActive(false);
        anim.ResetTrigger("move");
        anim.ResetTrigger("run");
        anim.SetTrigger("powrot");
        

        skrypt.animator.ResetTrigger("powrot");
        skrypt.animator.SetTrigger("move");
        skrypt.flaga = 0;
        skrypt.i = 0.5f;

    }
}
