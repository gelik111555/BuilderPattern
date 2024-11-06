namespace BuilderPattern;

public class Product
{
    public string Processor { get; set; }
    public string RAM { get; set; }
    public string Motherboard { get; set; }

    public override string ToString()
    {
        return $"Product [Processor: {Processor}, RAM: {RAM}, Motherboard: {Motherboard}]";
    }
}
