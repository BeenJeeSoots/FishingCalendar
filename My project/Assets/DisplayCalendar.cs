using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class DisplayCalendar : MonoBehaviour
{

    /// Every Cell in the calendar, each Day.
    public class Day {

        public int dayNum;          // 1 - 31
        public Color dayColor;      // White = Not active, Green = Active. 
        public GameObject obj;     

        /// Day Constructor
        public Day(int dayNum, Color dayColor, GameObject obj) {

            //Debug.Log("Day: dayNum, dayColor, obj:          " + dayNum + ",       " + dayColor + ",       " + obj.ToString());
            this.dayNum = dayNum;
            this.obj = obj;
            UpdateColor(dayColor);
            UpdateDay(dayNum);
        }

        /// Both the dayColor is updated, as well as the visual color on the screen.
        public void UpdateColor(Color newColor) {
            obj.GetComponent<Image>().color = newColor;
            dayColor = newColor;
        }

        public Color ReturnColor()
        {
            return dayColor;
        }

        // Determines day number or validity based on color of cell. 
        public void UpdateDay(int newDayNum) {
            this.dayNum = newDayNum;
            if(dayColor == Color.white || dayColor == Color.green)  { obj.GetComponentInChildren<TextMeshProUGUI>().text = (dayNum + 1).ToString(); }  //  If the day is valid, display number.
            else                                                    { obj.GetComponentInChildren<TextMeshProUGUI>().text = "";  }                      //  Otherwise make it empty.
        }
    }

    // All the days in the month. 
    private List<Day> days = new List<Day>();
    public static List<Day> staticdays = new List<Day>();

    // Collection of all 6 weeks. 
    public Transform[] weeks;

    // This is the text object that displays the current month and year
    [SerializeField] public TextMeshProUGUI MonthAndYear;

    // Date that our current calendar is on. Change this if picking another day. 
    public DateTime currDate = DateTime.Now;


    void Start() { UpdateCalendar(DateTime.Now.Year, DateTime.Now.Month); }

    void UpdateCalendar(int year, int month){
        
        DateTime temp           =    new DateTime(year, month, 1);
        this.currDate           =    temp;
        this.MonthAndYear.text  =    temp.ToString("MMMM") + " " + temp.Year.ToString();
        int startDay            =    GetMonthStartDay(year,month);
        int endDay              =    GetTotalNumberOfDays(year, month);

        
        // Creates days (Only happens at the beginning to create game objects)

        if(days.Count == 0) {                       // For every week (0 - 6), and for every day (0 - 7)
            for (int week = 0; week < 6; week++) {   
                for (int dayOfWeek = 0; dayOfWeek < 7; dayOfWeek++) {

                    Day newDay;
                    int currDayNum = (week * 7) + dayOfWeek;      // Our day will account for previous weeks before it. 

                    if (currDayNum < startDay || currDayNum - startDay >= endDay) {          // If our day is before day 1, or greater than the end of the month, make it gray. 
                        newDay = new Day(currDayNum - startDay, Color.grey, weeks[week].GetChild(dayOfWeek).gameObject);
                        }

                    else { 
                        newDay = new Day(currDayNum - startDay, Color.white,weeks[week].GetChild(dayOfWeek).gameObject); 
                        }                                                              // Otherwise make it a viable day with color white.                          

                    days.Add(newDay);   // Add it to our list of days. 
                    staticdays.Add(newDay);
                }
            }
        } // End of Day Creation

        // Loop through days, since game objects already exist we can use existing ones when going to new months. 
        else {
            for (int i = 0; i < 42; i++) {
                if (i < startDay || i - startDay >= endDay) {
                    days[i].UpdateColor(Color.grey);        // Invalid day, Grey. 
                    staticdays[i].UpdateColor(Color.grey);
                }
                else {
                    days[i].UpdateColor(Color.white);       // Valid day, White.
                    staticdays[i].UpdateColor(Color.white);
                }
                days[i].UpdateDay(i - startDay);            // Updates day number
                staticdays[i].UpdateDay(i - startDay);
            }
        }

        // Checks if day is current date. 
        if (DateTime.Now.Year == year && DateTime.Now.Month == month) {
            days[(DateTime.Now.Day - 1) + startDay].UpdateColor(Color.green);       // Valid day and it's today's date! Highlight it with green. 
            staticdays[(DateTime.Now.Day - 1) + startDay].UpdateColor(Color.green);
        }
    }



    // This returns which day of the week the month is starting on
    int GetMonthStartDay(int year, int month){
        DateTime temp = new DateTime(year, month, 1);
        return (int)temp.DayOfWeek;         // Sunday == 0, Saturday == 6 etc.
    }

    // Gets the number of days in the given month.
    int GetTotalNumberOfDays(int year, int month) { return DateTime.DaysInMonth(year, month);}


    //  This either adds or subtracts one month from our currDate.
    //  Function utilized to swap between future and past dates. 
    //  Direction = -1 (left) 1 (right)
    //  TODO: Make direction enum
    public void SwitchMonth(int direction)
    {
        if(direction < 0) { currDate = currDate.AddMonths(-1); }    // Go back 1 month
        else { currDate = currDate.AddMonths(1); }                  // Go forwards 1 month

        UpdateCalendar(currDate.Year, currDate.Month);
    }


    //void Update() { }     Unused update statement. 
}
