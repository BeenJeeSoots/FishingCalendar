using System

public class Event : CalendarItem {

    public string location;
    public TimeOnly startTime;
    public TimeOnly endTime;

    public Event(string title, string description, string location, TimeOnly startTime, TimeOnly endTime){
        this.title = title;
        this.description = description;
        this.location = location;
        this.startTime = startTime;
        this.endTime = endTime;

    }

}