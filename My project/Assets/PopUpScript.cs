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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
