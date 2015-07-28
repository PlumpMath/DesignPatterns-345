using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern
{
    public class ConcreteFactoryA : Factory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
}
