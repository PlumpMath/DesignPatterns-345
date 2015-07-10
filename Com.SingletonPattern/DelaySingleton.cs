using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Com.SingletonPattern
{
    /// <summary>
    /// 功能：延迟加载单例模式 利用DotNet的特性
    /// 编写：willieni
    /// 日期：2015年07月10日
    /// 备注：延迟加载
    /// </summary>
    public class DelaySingleton : ISingleton
    {
        private DelaySingleton()
        {
        }

        public static DelaySingleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        class Nested
        {
            static Nested()
            {
                ///线程延迟2000毫秒
                Thread.Sleep(2000);
            }

            internal static readonly DelaySingleton instance = new DelaySingleton();
        }

    }
}
