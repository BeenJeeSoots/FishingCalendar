using System

public class Task : CalendarItem {

    public bool completed

    public Task(string title, string description){
        this.title = title;
        this.description = description;
        this.completed = false;
    }

}