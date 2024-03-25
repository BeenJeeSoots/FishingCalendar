using System;

public class Event : CalendarItem {

    public string location;
    public string startTime;
    public string endTime;

    public Event(string title, string description, string location, string startTime, string endTime){
        this.title = title;
        this.description = description;
        this.location = location;
        this.startTime = startTime;
        this.endTime = endTime;

    }

}