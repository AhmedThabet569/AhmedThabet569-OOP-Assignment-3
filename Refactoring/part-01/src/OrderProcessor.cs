namespace RefactoringLab;
public interface IDBOrderRepository
{
    public void Save(int orderId, DateTime processedAt);
}

public interface ISendingEmail
{
    public void Send(string to, string body);
}
public class OrderProcessor
{
    private readonly IDBOrderRepository _repo;
    private readonly ISendingEmail _smtp;

    public OrderProcessor(IDBOrderRepository repo, ISendingEmail smtp)
    {
        _repo = repo;
        _smtp = smtp;
    }

    public void Process(int orderId, string customerEmail)
    {
        //var repo = new SqlOrderRepository();
        //var email = new SmtpEmailSender();

        _repo.Save(orderId, DateTime.Now);
        _smtp.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
       
    }
}

public class SqlOrderRepository:IDBOrderRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public class SmtpEmailSender:ISendingEmail
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}
