using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Calendar
{
    Day[] DayArray;
    

    public Day getDay(DateTime date){

        return null;
    }

    public Event[] GetEvents(Day day){
        
        return null;
    }

    public Day CreateDay(Day d){

        DateTime chosenDay = d.currentDate;

         for(int i = 0; i < DayArray.Length; i++){
            if(DayArray[i].currentDate == chosenDay) { return DayArray[i];}
        }
        
        return new Day(chosenDay);
        
    }



}
