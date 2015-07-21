using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Human
{
    /// <summary>
    /// 黑人男性
    /// </summary>
    public class MaleBlackHuman : AbstractBlackHuman
    {
        public override void GetSex()
        {
            Console.WriteLine("黑人男性");
        }

    }
}
