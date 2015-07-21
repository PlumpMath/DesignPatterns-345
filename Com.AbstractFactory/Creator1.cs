using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.AbstractFactoryPattern
{
    /**
     * 工厂1，只生产跳线为1的产品
     */
    public class Creator1 : AbstractCreator
    {

        //只生产产品等级为1的A产品
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        //只生产铲平等级为1的B产品
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
