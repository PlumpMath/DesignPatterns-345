using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Human
{
    /// <summary>
    /// 抽象黄种人
    /// </summary>
    public abstract class AbstractYellowHuman : Human
    {
        public void GetColor()
        {
            Console.WriteLine("黄色人种的皮肤颜色是黄色的！");
        }

        public void Talk()
        {
            Console.WriteLine("黄色人种会说话，一般说的都是双字节。");
        }

        public abstract void GetSex();
    }
}
