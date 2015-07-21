using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.AbstractFactoryPattern
{
    /// <summary>
    /// 产品B
    /// </summary>
    public abstract class AbstractProductB
    {

        //每个产品共有的方法
        public void ShareMethod()
        {

        }

        //每个产品相同方法，不同实现
        public abstract void DoSomething();
    }
}
