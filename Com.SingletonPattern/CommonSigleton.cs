using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.SingletonPattern
{
    /// <summary>
    /// 功能：简单的单件模式类
    /// 编写：willieni
    /// 日期：2015年07月10日
    /// 备注：多线程下可能有多个实例
    /// </summary>
    public class CommonSingleton : ISingleton
    {
        /// <summary> 
        /// 私有的对象
        /// </summary>
        private static CommonSingleton instance;

        /// <summary>
        /// 构造方法为Private
        /// </summary>
        private CommonSingleton()
        {

        }

        /// <summary>
        /// 公有的属性
        /// </summary>
        public static CommonSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CommonSingleton();
                }

                return instance;
            }
        }
         
    }
}
