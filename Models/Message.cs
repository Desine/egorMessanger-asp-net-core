namespace egorMessenger.Models;


public class Message{
    public int Id {get; set;}
    public string Text {get; set;} = "";
    public DateTime CreationTime {get; set;} = DateTime.UtcNow;
}