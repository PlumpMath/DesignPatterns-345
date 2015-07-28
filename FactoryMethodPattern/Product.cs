using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern
{
    /// <summary>
    /// 定义Product抽象类，Client调用Product抽象类，并由Factory来创建具体类。
    /// </summary>
    public abstract class Product
    {
        //产品类的公共方法
        public void Method1()
        {
            //业务逻辑处理
        }

        //抽象方法1
        public abstract void Method2();
    }
}
