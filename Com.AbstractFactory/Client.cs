using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.AbstractFactoryPattern
{
    public class Client
    {
        public static void Main(String[] args)
        {
            //定义出两个工厂
            AbstractCreator creator1 = new Creator1();
            AbstractCreator creator2 = new Creator2();

            //产生A1对象
            AbstractProductA a1 = creator1.CreateProductA();
            //产生A2对象
            AbstractProductA a2 = creator2.CreateProductA();
            //产生B1对象
            AbstractProductB b1 = creator1.CreateProductB();
            //产生B2对象
            AbstractProductB b2 = creator2.CreateProductB();

            a1.DoSomething();
            a2.DoSomething();
            b1.DoSomething();
            b2.DoSomething();

            /*
             * 然后在这里就可以为所欲为了...
             */

        }
    }
}
