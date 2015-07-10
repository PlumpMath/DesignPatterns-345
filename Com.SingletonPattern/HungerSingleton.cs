using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.SingletonPattern
{
    /// <summary>
    /// 功能：利用DotNet的特性实现单件模式
    /// 编写：WillieNi
    /// 日期：2015年07月10日
    /// </summary> 
    public class HungerSingleton
    {
        //饿汉单例模式，解决多线程并发出现多个实例问题
        private static readonly HungerSingleton instance = new HungerSingleton();

        private HungerSingleton() { }

        public static HungerSingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
