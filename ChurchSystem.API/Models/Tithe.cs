namespace ChurchSystem.API;

public class Tithe
{
    public MeetingTypes MeetingType { get; set; }

    public double CollectionedAmount { get; set; }

    public DateTime Date { get; set; }
}