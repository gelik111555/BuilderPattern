using BuilderPattern.Interfaces;

namespace BuilderPattern.Builders;

public class ComputerBuilder : IBuilder
{
    private Product _product = new Product();

    public IBuilder SetProcessor(string processor)
    {
        _product.Processor = processor;
        return this;
    }

    public IBuilder SetRAM(string ram)
    {
        _product.RAM = ram;
        return this;
    }

    public IBuilder SetMotherboard(string motherboard)
    {
        _product.Motherboard = motherboard;
        return this;
    }

    public Product GetResult()
    {
        // Возвращаем продукт и сбрасываем текущий экземпляр для новой сборки
        Product result = _product;
        _product = new Product();
        return result;
    }
}
