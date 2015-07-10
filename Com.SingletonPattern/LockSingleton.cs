using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.SingletonPattern
{
    /// <summary>
    /// 功能：在C#用双重锁定实现单件模式
    /// 编写：willieni
    /// 日期：2015年07月10日
    public class LockSingleton
    {

        private static volatile LockSingleton instance;

        /// <summary>
        /// 辅助锁对象，本身没有意义 
        /// </summary>
        private static object syncRoot = new Object();

        /// <summary>
        /// 构造方法改为Private
        /// </summary>
        private LockSingleton()
        {

        }

        public static LockSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new LockSingleton();
                    }
                }

                return instance;
            }
        }

    }
}
