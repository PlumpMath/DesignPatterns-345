using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.AbstractFactoryPattern
{
    /**
     * 产品A的实现类
     */
    public class ProductA2 : AbstractProductA
    {
        public override void DoSomething()
        {
            Console.WriteLine("产品A2的实现方法");
        }
    }
}
