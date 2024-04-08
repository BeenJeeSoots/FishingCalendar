using System;

public class Event  {

    public string Location;
    public string StartTime;
    public string EndTime;
    public string Title;
    public string Description;

    Day EventDay;

    public Event(string title, string description, string location, string startTime, string endTime){
        this.Title = title;
        this.Description = description;
        this.Location = location;
        this.StartTime = startTime;
        this.EndTime = endTime;
    }

    public Event CreateEvent(string title, string description, string location, string startTime, string endTime){
        return new Event( title,  description,  location,  startTime,  endTime);
    }

}