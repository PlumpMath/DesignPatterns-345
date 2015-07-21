using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.AbstractFactoryPattern
{
    /// <summary>
    /// 产品A的实现类
    /// </summary>
    public class ProductA1 : AbstractProductA
    {
        public override void DoSomething()
        {
            Console.WriteLine("产品A1的实现方法");
        }

    }
}
