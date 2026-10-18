namespace RefactoringLab;

//my solution 
public abstract class ShippingCompanyCalculate
{
    protected abstract decimal companyPrice { get; }
    public virtual  decimal Calculate(decimal weightKG)
    {
        return weightKG * companyPrice;
    }
}
public class Aramex : ShippingCompanyCalculate
{
    protected override decimal companyPrice => 12m;
}
public class FedEx : ShippingCompanyCalculate
{
    protected override decimal companyPrice => 15m;
}
public class DHL : ShippingCompanyCalculate
{
    protected override decimal companyPrice => 18m;
}
public class ShippingCostCalculator
{
    public decimal Calculate(ShippingCompanyCalculate carrier, decimal weightKg)
    {
        return carrier.Calculate(weightKg);
    }
}
