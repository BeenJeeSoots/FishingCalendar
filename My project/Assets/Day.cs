using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day
{
   public DateTime currentDate;
   public Event[] TodaysEvents;

    public Day(DateTime date){

        
    }

    public Day CreateDay(DateTime date){

        return new Day(date);
    }

    public Event AddEvent(Day day){

        return null;
    }

}
