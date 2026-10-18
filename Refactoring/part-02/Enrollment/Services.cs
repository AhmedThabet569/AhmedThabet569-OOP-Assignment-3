namespace RefactoringLab.Part02.Enrollment;

public class PaymentGateway
{
    public void Charge(string studentId, decimal amount) =>
        Console.WriteLine($"charge {studentId}: {amount}");
}

public class SeatInventory
{
    public void Reserve(string courseId, string studentId) =>
        Console.WriteLine($"reserve seat {courseId} for {studentId}");
}

public class InvoiceGenerator
{
    public string Create(string studentId, decimal amount)
    {
        var invoiceId = $"INV-{studentId}-{amount}";
        Console.WriteLine($"invoice {invoiceId}");
        return invoiceId;
    }
}

public class EmailService
{
    public void Send(string studentId, string subject, string body) =>
        Console.WriteLine($"email {studentId}: {subject} / {body}");
}


public class EnrollmentService
{
    private readonly SeatInventory seatInventory ;
    private readonly InvoiceGenerator invoiceGenerator ;
    private readonly EmailService emailService ;
    private readonly PaymentGateway paymentGateway ;
      
    public EnrollmentService()
    {
      seatInventory = new SeatInventory();
      invoiceGenerator = new InvoiceGenerator();
      emailService = new EmailService();
      paymentGateway = new PaymentGateway();
    }
    public void RunService(string courseId, string studentId,decimal amount, string subject, string body)
    {
        seatInventory.Reserve(courseId, studentId);
        paymentGateway.Charge(studentId, amount);
    }

    public string GenerteId(string studentId, decimal amount)
    {
        return invoiceGenerator.Create(studentId,amount);
    }

    public void Send(string courseId, string studentId, decimal amount, string subject, string body,bool addIvoice=false)
    {
        if(addIvoice)
            body += GenerteId(studentId, amount);
        Console.WriteLine($"send {courseId}: {studentId}: {amount} / {subject} / {body}");
    }
    // public void Send(string studentId, decimal amount, string subject);
    // {
    //     Console.WriteLine($"email {studentId}: {subject} / {body}");
    // }
}