using System;

public class Event : CalendarItem {

    public string Location;
    public string StartTime;
    public string EndTime;

    Day EventDay;

    public Event(string title, string description, string location, string startTime, string endTime){
        this.title = title;
        this.description = description;
        this.Location = location;
        this.StartTime = startTime;
        this.EndTime = endTime;
    }

    public Event CreateEvent(string title, string description, string location, string startTime, string endTime){
        return new Event( title,  description,  location,  startTime,  endTime);
    }

}