using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.AbstractFactoryPattern
{
    /// <summary>
    /// 抽象的产品类
    /// </summary>
    public abstract class AbstractCreator
    {
        //创建A产品家族
        public abstract AbstractProductA CreateProductA();

        //创建B产品家族
        public abstract AbstractProductB CreateProductB();
    }
}
