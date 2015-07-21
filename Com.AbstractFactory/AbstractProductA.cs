using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.AbstractFactoryPattern
{
    /// <summary>
    /// 产品A
    /// </summary>
    public abstract class AbstractProductA
    {
        //每个产品共有的方法
        public void ShareMethod()
        {

        }

        //每个产品相同方法，不同实现
        public abstract void DoSomething();
    }

}
