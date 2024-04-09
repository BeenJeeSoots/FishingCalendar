using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class PopUpScript : MonoBehaviour
{

    public GameObject PopUp;
    public Color datecolor;

    void Start(){}
    void Update(){}

    public void PopupSetVis()
    {
        datecolor = DisplayCalendar.staticdays[DayLogic.currday].ReturnColor();
        if (datecolor != Color.grey)
        {
            PopUp.SetActive(true);
        }
    }

    public void PopupSetInvis()
    {
        PopUp.SetActive(false);
    }

}
