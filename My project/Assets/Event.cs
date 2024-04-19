using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

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

    public void SaveEvent()
    {
        string filePath = "eventsDatabase.txt";
        try
        {
            using StreamWriter writer = new StreamWriter(filePath, true);
            writer.WriteLine($"Title: {title}");
            writer.WriteLine($"Description: {description}");
            writer.WriteLine($"Location: {Location}");
            writer.WriteLine($"Start Time: {StartTime}");
            writer.WriteLine($"End Time: {EndTime}");
            writer.WriteLine();
        }
        catch (Exception e)
        {
            Debug.WriteLine($"Error saving event to file: {e.Message}");
        }
    }


    public Event[] LoadEvents()
    {
        Event[] events = new Event[100];
        string filePath = "eventsDatabase.txt";
        try
        {
            // here is where we would iterate through the list in the database and obtain all of them
            // Perhaps enumerate each event with an index. 
            using StreamReader reader = new StreamReader(filePath);
            string title = reader.ReadLine()?.Split(':')[1].Trim();
            string description = reader.ReadLine()?.Split(':')[1].Trim();
            string location = reader.ReadLine()?.Split(':')[1].Trim();
            string startTime = reader.ReadLine()?.Split(':')[1].Trim();
            string endTime = reader.ReadLine()?.Split(':')[1].Trim();

            events.Append(new Event(title, description, location, startTime, endTime));
        }
        catch (Exception e)
        {
            Debug.WriteLine($"Error loading event from file: {e.Message}");
            return null;
        }
        return events;
    }





}