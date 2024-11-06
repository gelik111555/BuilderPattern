using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Interfaces;

public interface IBuilder
{
    IBuilder SetProcessor(string processor);
    IBuilder SetRAM(string ram);
    IBuilder SetMotherboard(string motherboard);
    Product GetResult();
}
