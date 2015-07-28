using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern
{
    public class ConcreteFactoryB : Factory
    {
        public override Product CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
