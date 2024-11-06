using BuilderPattern.Interfaces;

namespace BuilderPattern;

public class Director
{
    public void ConstructGamingComputer(IBuilder builder)
    {
        builder
            .SetProcessor("High-End Processor")
            .SetRAM("32GB DDR4")
            .SetMotherboard("Gaming Motherboard");
    }

    public void ConstructOfficeComputer(IBuilder builder)
    {
        builder
            .SetProcessor("Mid-Range Processor")
            .SetRAM("16GB DDR4")
            .SetMotherboard("Standard Motherboard");
    }
}
