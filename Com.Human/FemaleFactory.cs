using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Human
{
    /// <summary>
    /// 女性工厂
    /// </summary>
    public class FemaleFactory : HumanFactory
    {
        //生产出黑人女性
        public Human CreateBlackHuman()
        {
            return new FemaleBlackHuman();
        }

        //生产出白人女性
        public Human CreateWhiteHuman()
        {
            return new FemaleWhiteHuman();
        }

        //生产出黄人女性
        public Human CreateYellowHuman()
        {
            return new FemaleYellowHuman();
        }

    }
}
