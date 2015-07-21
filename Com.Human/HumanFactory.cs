using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Human
{
    /// <summary>
    /// 这次定一个接口，应该要造不同性别的人，需要不同的生产线
    /// 那这个八卦炉必须可以制造男人和女人
    /// </summary>
    public interface HumanFactory
    {
        //制造一个黄色人种
        Human CreateYellowHuman();

        //制造一个白色人种
        Human CreateWhiteHuman();

        //制造一个黑色人种
        Human CreateBlackHuman();
    }
}
