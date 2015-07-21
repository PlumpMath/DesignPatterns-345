using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Human
{
    /// <summary>
    /// 抽象白种人
    /// </summary>
    public abstract class AbstractWhiteHuman : Human
    {

        //白色人种的颜色是白色的
        public void GetColor()
        {
            Console.WriteLine("白色人种的皮肤颜色是白色的！");
        }

        //白色人种讲话
        public void Talk()
        {
            Console.WriteLine("白色人种会说话，一般都是但是单字节。");

        }

        public abstract void GetSex();
    }
}
