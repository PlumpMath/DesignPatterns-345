using System;
using System.Collections;

namespace DesignPatterns.Builder.KFC
{
    /// <summary>
    /// Food类，即产品类
    /// </summary>
    public class Food
    {
        Hashtable food = new Hashtable();

        /// <summary>
        /// 添加食品
        /// </summary>
        /// <param name="strName">食品名称</param>
        /// <param name="Price">价格</param>
        public void Add(string strName, string Price)
        {
            food.Add(strName, Price);
        }

        /// <summary>
        /// 显示食品清单
        /// </summary>
        public void Show()
        {
            IDictionaryEnumerator myEnumerator = food.GetEnumerator();
            Console.WriteLine("Food List:");
            Console.WriteLine("------------------------------");
            string strfoodlist = "";
            while (myEnumerator.MoveNext())
            {
                strfoodlist = strfoodlist + "\n\n" + myEnumerator.Key.ToString();
                strfoodlist = strfoodlist + ":\t" + myEnumerator.Value.ToString();
            }
            Console.WriteLine(strfoodlist);
            Console.WriteLine("\n------------------------------");
        }
    }
}
