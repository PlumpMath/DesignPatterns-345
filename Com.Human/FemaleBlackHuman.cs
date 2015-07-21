using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Human
{
    /// <summary>
    /// 女性黑人
    /// </summary>
    public class FemaleBlackHuman : AbstractBlackHuman
    {
        public override void GetSex()
        {
            Console.WriteLine("黑人女性");
        }

    }
}
