using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.AbstractFactoryPattern
{
    /**
     * 工厂2，只生产跳线为2的产品
     */
    public class Creator2 : AbstractCreator
    {

        //只生产产品等级为2的A产品
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        //只生产铲平等级为2的B产品
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
