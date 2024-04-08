using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpScript : MonoBehaviour
{
    public GameObject PopUp;
  
    void Start(){}
    void Update(){}

    public void PopupSetVis()
    {
        PopUp.SetActive(true);
    }

    public void PopupSetInvis()
    {
        PopUp.SetActive(false);
    }

}
