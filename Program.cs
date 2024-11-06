using BuilderPattern.Interfaces;
using BuilderPattern;
using BuilderPattern.Builders;

class Program
{
    static void Main(string[] args)
    {
        IBuilder builder = new ComputerBuilder();

        // Конфигурируем игровой компьютер вручную
        Product gamingComputer = builder
            .SetProcessor("Intel Core i9")
            .SetRAM("32GB DDR4")
            .SetMotherboard("ASUS ROG Gaming")
            .GetResult();

        Console.WriteLine("Игровой компьютер: " + gamingComputer);

        // Конфигурируем офисный компьютер вручную
        Product officeComputer = builder
            .SetProcessor("Intel Core i5")
            .SetRAM("16GB DDR4")
            .SetMotherboard("MSI Office Series")
            .GetResult();

        Console.WriteLine("Офисный компьютер: " + officeComputer);

        // Конфигурируем минимальную конфигурацию (например, только процессор)
        Product basicComputer = builder
            .SetProcessor("Intel Core i3")
            .GetResult();

        Console.WriteLine("Базовая конфигурация компьютера: " + basicComputer);
    }
}
