namespace ChurchSystem.API;
public enum MeetingType
{
    SWS = 1,
    MBS = 2,

    WPF = 3,

    THR = 4,

    SWT = 5,

    GCK = 6


}

public class Attendance
{
    public double Brothers { get; set; }

    public double Sisters { get; set; }

    public MeetingType MeetingType { get; set; }
}