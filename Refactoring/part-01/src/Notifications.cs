namespace RefactoringLab;

public interface ISendNotification
{
    void Send(string to, string message);
}
public abstract class Notification
{

    public  void SendCore(string to, string message)
    {
        Send(to, message);
    }
    protected  abstract void Send(string to, string message);
}



public class EmailNotification : ISendNotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}

public class SmsNotification : ISendNotification
{
    public void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
}

public class UrgentEmailNotification : Notification
{
    protected override void Send(string to, string message) =>
        base.SendCore(to, $"[URGENT] {message}");
}

public class UrgentSmsNotification : Notification
{
    protected override void Send(string to, string message) =>
        base.SendCore(to, $"[URGENT] {message}");
}

public class UrgentScheduledEmailNotification : Notification
{
    public DateTime SendAt { get; set; }

    protected override void Send(string to, string message) =>
        Console.WriteLine($"[email scheduled {SendAt:g}] {to}: [URGENT] {message}");
}

public class UrgentScheduledSmsNotification : Notification
{
    public DateTime SendAt { get; set; }

    protected override void Send(string to, string message) =>
        Console.WriteLine($"[sms scheduled {SendAt:g}] {to}: [URGENT] {message}");
}
