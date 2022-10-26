namespace ChurchSystem.API;

public class Tithe
{
    public MeetingType MeetingType { get; set; }

    public double CollectionedAmount { get; set; }

    public DateTime Date { get; set; }
}