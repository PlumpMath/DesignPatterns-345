using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern
{
    public abstract class Factory
    {
        public abstract Product CreateProduct();
    }
}
