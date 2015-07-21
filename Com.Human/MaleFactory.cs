using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Human
{
    /// <summary>
    /// 男性工厂
    /// </summary>
    public class MaleFactory : HumanFactory
    {
        //生产出黑人男性
        public Human CreateBlackHuman()
        {
            return new MaleBlackHuman();
        }

        //生产出白人男性
        public Human CreateWhiteHuman()
        {
            return new MaleWhiteHuman();
        }

        //生产出黄人男性
        public Human CreateYellowHuman()
        {
            return new MaleYellowHuman();
        }

    }

}
