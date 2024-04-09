using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// This file will contain the logic for the day objects, as well as create the popup window on the days when clicked, to create events and to-do's. 
// Events and to-do's will also be written and accessed here. 

public class DayLogic : MonoBehaviour
{
    private UnityAction okayResponse;
    private UnityAction cancelResponse;
    public static int currday;
    public int day;

    public void Day_Button(){
        currday = day;
    }

    public void PopupOkay_Pressed(){
        // Method that is called when 'OK' is pressed.
    }

    public void PopupCancel_Pressed(){
        // Method that is called when 'CANCEL' is pressed.
    }
    

    // When 'OK' is pressed, we call the OK response action.
    public void  OK_Button(){
        okayResponse?.Invoke();
        okayResponse = null;
        Debug.Log("OK");
    }

    // When 'CANCEL' button is clicked, we will call Cancel response action.
    public void CANCEL_Button(){
        cancelResponse?.Invoke();
        cancelResponse = null;
        Debug.Log("CANCEL");
    }

    public void SetResponses(UnityAction okay, UnityAction cancel){
        okayResponse = okay;
        cancelResponse = cancel;
    }



    





    // Start is called before the first frame update
    void Start() {}

    // Update is called once per frame
    void Update() { }




}
