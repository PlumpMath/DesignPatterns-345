using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.AbstractFactoryPattern
{

    /**
     * 产品A的实现类
     */
    public class ProductB2 : AbstractProductB
    {

        public override void DoSomething()
        {
            Console.WriteLine("产品B2的实现方法");
        }

    }

}
