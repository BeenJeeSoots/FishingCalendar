using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpScript : MonoBehaviour
{
    public GameObject PopUp;
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
        PopUp.SetActive(true);
    }

    public void PopupSetInvis()
    {
        PopUp.SetActive(false);
    }

}
