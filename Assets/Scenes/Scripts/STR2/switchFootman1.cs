using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class switchFootman1 : MonoBehaviour
{

    private int flaga = 0;
    public GameObject footMan1;
    public GameObject footMan2;
    public GameObject footMan3;
    public GameObject footMan4;
    public GameObject footMan1_2;
    public GameObject footMan1_3;
    public GameObject footMan1_4;
    public GameObject footMan2_1;
    public GameObject footMan2_3;
    public GameObject footMan2_4;
    public GameObject footMan3_1;
    public GameObject footMan3_2;
    public GameObject footMan3_4;
    public GameObject footMan4_1;
    public GameObject footMan4_2;
    public GameObject footMan4_3;
    public Canvas canvas;
    public Text txt;


    void Start()
    {
        canvas = canvas.GetComponent<Canvas>();
        txt = txt.GetComponent<Text>();
        footMan1 = GameObject.FindGameObjectWithTag("footMan1");
        footMan2 = GameObject.FindGameObjectWithTag("footMan2");
        footMan3 = GameObject.FindGameObjectWithTag("footMan3");
        footMan4 = GameObject.FindGameObjectWithTag("footMan4");
        footMan1_2 = GameObject.FindGameObjectWithTag("footMan1_2");
        footMan1_3 = GameObject.FindGameObjectWithTag("footMan1_3");
        footMan1_4 = GameObject.FindGameObjectWithTag("footMan1_4");
        footMan2_1 = GameObject.FindGameObjectWithTag("footMan2_1");
        footMan2_3 = GameObject.FindGameObjectWithTag("footMan2_3");
        footMan2_4 = GameObject.FindGameObjectWithTag("footMan2_4");
        footMan3_1 = GameObject.FindGameObjectWithTag("footMan3_1");
        footMan3_2 = GameObject.FindGameObjectWithTag("footMan3_2");
        footMan3_4 = GameObject.FindGameObjectWithTag("footMan3_4");
        footMan4_1 = GameObject.FindGameObjectWithTag("footMan4_1");
        footMan4_2 = GameObject.FindGameObjectWithTag("footMan4_2");
        footMan4_3 = GameObject.FindGameObjectWithTag("footMan4_3");
        txt.enabled = false;
       
    }

    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                if(flaga == 0)
                {
                    
                 footMan1_2.transform.localPosition = new Vector3(0.2f, 0.001f, 0.11f);
                 footMan2_4.transform.localPosition = new Vector3(0.05f, 0.001f, 0.11f);
                 footMan3_1.transform.localPosition = new Vector3(-0.1f, 0.001f, 0.11f);
                 footMan4_3.transform.localPosition = new Vector3(-0.25f, 0.001f, 0.11f);
                 footMan1.transform.localPosition = new Vector3(0.2f, 5f, 0.11f);
                 footMan2.transform.localPosition = new Vector3(0.05f, 5f, 0.11f);
                 footMan3.transform.localPosition = new Vector3(-0.1f, 5f, 0.11f);
                 footMan4.transform.localPosition = new Vector3(-0.25f, 5f, 0.11f);

                 flaga = 1;
                 txt.enabled = false;

                }
                else if(flaga == 1)
                {
                    footMan1_4.transform.localPosition = new Vector3(0.2f, 0.001f, 0.11f);
                    footMan2_3.transform.localPosition = new Vector3(0.05f, 0.001f, 0.11f);
                    footMan3_2.transform.localPosition = new Vector3(-0.1f, 0.001f, 0.11f);
                    footMan4_1.transform.localPosition = new Vector3(-0.25f, 0.001f, 0.11f);
                    footMan1_2.transform.localPosition = new Vector3(0.25f, 5f, 0.11f);
                    footMan2_4.transform.localPosition = new Vector3(0.05f, 5f, 0.11f);
                    footMan3_1.transform.localPosition = new Vector3(-0.1f, 5f, 0.11f);
                    footMan4_3.transform.localPosition = new Vector3(-0.25f, 5f, 0.11f);
                    flaga =  2;
                    txt.enabled = false;
                }  
                else if(flaga == 2)
                {
                    footMan1_4.transform.localPosition = new Vector3(0.2f, 5f, 0.11f);
                    footMan2_3.transform.localPosition = new Vector3(0.05f, 5f, 0.11f);
                    footMan3_2.transform.localPosition = new Vector3(-0.1f, 5f, 0.11f);
                    footMan4_1.transform.localPosition = new Vector3(-0.25f, 5f, 0.11f);
                    footMan1_3.transform.localPosition = new Vector3(0.2f, 0.001f, 0.11f);
                    footMan2_1.transform.localPosition = new Vector3(0.05f, 0.001f, 0.11f);
                    footMan3_4.transform.localPosition = new Vector3(-0.1f, 0.001f, 0.11f);
                    footMan4_2.transform.localPosition = new Vector3(-0.25f, 0.001f, 0.11f);
                    flaga = 3;
                    txt.enabled = false;
                }
                else if(flaga == 3)
                {
                    footMan1_3.transform.localPosition = new Vector3(0.2f, 5f, 0.11f);
                    footMan2_1.transform.localPosition = new Vector3(0.05f, 5f, 0.11f);
                    footMan3_4.transform.localPosition = new Vector3(-0.1f, 5f, 0.11f);
                    footMan4_2.transform.localPosition = new Vector3(-0.25f, 5f, 0.11f);
                    footMan1.transform.localPosition = new Vector3(0.2f, 0.001f, 0.11f);
                    footMan2_3.transform.localPosition = new Vector3(0.05f, 0.001f, 0.11f);
                    footMan3_4.transform.localPosition = new Vector3(-0.1f, 0.001f, 0.11f);
                    footMan4_1.transform.localPosition = new Vector3(-0.25f, 0.001f, 0.11f);
                    flaga = 4;
                    txt.enabled = false;
                }
                else if(flaga == 4)
                {
                    footMan1.transform.localPosition = new Vector3(0.2f, 5f, 0.11f);
                    footMan2_3.transform.localPosition = new Vector3(0.05f, 5f, 0.11f);
                    footMan3_4.transform.localPosition = new Vector3(-0.1f, 5f, 0.11f);
                    footMan4_1.transform.localPosition = new Vector3(-0.25f, 5f, 0.11f);
                    footMan1_3.transform.localPosition = new Vector3(0.2f, 0.001f, 0.11f);
                    footMan2_3.transform.localPosition = new Vector3(0.05f, 0.001f, 0.11f);
                    footMan3.transform.localPosition = new Vector3(-0.1f, 0.001f, 0.11f);
                    footMan4_3.transform.localPosition = new Vector3(-0.25f, 0.001f, 0.11f);
                    flaga = 5;
                    txt.enabled = true;
                } 
                else if(flaga == 5)
                {
                    footMan1_3.transform.localPosition = new Vector3(0.2f, 5f, 0.11f);
                    footMan2_3.transform.localPosition = new Vector3(0.05f, 5f, 0.11f);
                    footMan3.transform.localPosition = new Vector3(-0.1f, 5f, 0.11f);
                    footMan4_3.transform.localPosition = new Vector3(-0.25f, 5f, 0.11f);
                    footMan1.transform.localPosition = new Vector3(0.2f, 0.001f, 0.11f);
                    footMan2.transform.localPosition = new Vector3(0.05f, 0.001f, 0.11f);
                    footMan3.transform.localPosition = new Vector3(-0.1f, 0.001f, 0.11f);
                    footMan4.transform.localPosition = new Vector3(-0.25f, 0.001f, 0.11f);
                    flaga = 0;
                    txt.enabled = false;
                }
            }
        }
    }
}
