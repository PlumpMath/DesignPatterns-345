using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Human
{
    /// <summary>
    /// 定义一个人类的统称
    /// </summary>
    public interface Human
    {
        //每个人种都有相应的颜色
        void GetColor();

        //人类会说话
        void Talk();

        //每个人都有性别
        void GetSex();
    }
}
