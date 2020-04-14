using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuStart : MonoBehaviour
{
    public Canvas can;
    public Camera cam;
    public Button btnStart;
    public Text txt;
    public Text txt2;
    public Text txt3;

    void Start()
    {
        can = can.GetComponent<Canvas>();
        cam = cam.GetComponent<Camera>();
        txt = txt.GetComponent<Text>();
        txt2 = txt2.GetComponent<Text>();
        txt3 = txt3.GetComponent<Text>();
        btnStart = btnStart.GetComponent<Button>();

        can.enabled = true;
        cam.enabled = false;
    }

   public void PrzyciskStart()
    {
        can.enabled = false;
        cam.enabled = true;
        txt2.enabled = true;
        btnStart.enabled = true;
    }

    public void PrzyciskPausa()
    {
        cam.enabled = false;
        can.enabled = true;
        txt.enabled = false;
        txt2.enabled = false;
        txt3.enabled = false;
        btnStart.enabled = true;
    }


}
