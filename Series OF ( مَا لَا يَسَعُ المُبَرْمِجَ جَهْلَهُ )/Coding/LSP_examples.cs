// ========================================================
// Best Practice (Abstractions)
// ========================================================
public interface IPaymentProcessor
{
    bool CanProcess(decimal amount);
    void Process(decimal amount);
}

// ========================================================
// condition
// ========================================================
if (amount < 100)
{
    // condition example
}

// ========================================================
// Implicitly
// ========================================================
Process(amount);

// ========================================================
// Method
// ========================================================
void MakeBirdFly(Bird bird)
{
    bird.Fly();
}

// ========================================================
// Method Call
// ========================================================
MakeBirdFly(new Ostrich());

// ========================================================
// New Implementation
// ========================================================
public class CryptoPayment : PaymentProcessor
{
    public override void Process(decimal amount)
    {
        if (amount < 100)
            throw new Exception("Minimum 100 required");
    }
}

// ========================================================
// Payment Service
// ========================================================
public abstract class PaymentProcessor
{
    public abstract void Process(decimal amount);
}

// ========================================================
// The Usual Example
// ========================================================
public class Bird
{
    public virtual void Fly()
    {
        Console.WriteLine("Flying...");
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException();
    }
}
