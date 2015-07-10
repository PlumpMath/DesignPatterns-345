using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.SingletonPattern
{
    /// <summary>
    /// 功能：懒汉式单例类.
    /// 编写：willieni
    /// 日期：2015年07月10日
    /// 备注：在第一次调用的时候实例化自己，多线程下可能有多个实例
    /// </summary>
    public class LazySingleton : ISingleton
    {
        /// <summary> 
        /// 私有的对象
        /// </summary>
        private static LazySingleton instance;

        /// <summary>
        /// 构造方法为Private
        /// </summary>
        private LazySingleton()
        {

        }

        /// <summary>
        /// 公有的属性
        /// </summary>
        public static LazySingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LazySingleton();
                }

                return instance;
            }
        }
         
    }
}
