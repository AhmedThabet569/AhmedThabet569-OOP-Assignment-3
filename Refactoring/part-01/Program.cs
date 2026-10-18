using RefactoringLab;

var shipping = new ShippingCostCalculator();
var aramex = new Aramex();
var fedex = new FedEx();
Console.WriteLine($"Aramex 2kg → {shipping.Calculate(aramex, 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(fedex, 2)}");
Console.WriteLine();

var smpt = new SmtpEmailSender();
var sqlServer = new SqlOrderRepository();
var processor = new OrderProcessor(sqlServer,smpt);
processor.Process(1001, "customer@example.com");
Console.WriteLine();

new UrgentScheduledEmailNotification { SendAt = DateTime.Today.AddHours(18) }
    .SendCore("customer@example.com", "Your order ships tomorrow");
new UrgentSmsNotification()
    .SendCore("+201000000000", "OTP 4821");
