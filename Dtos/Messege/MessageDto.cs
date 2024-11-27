namespace egorMessenger.Dtos.Messege;


public class MessageDto{
    public int Id {get; set;}
    public string Text {get; set;} = "";
    public DateTime CreationTime {get; set;} = DateTime.UtcNow;
}