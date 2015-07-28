using System;
using System.Collections;

namespace DesignPatterns.Builder.KFC
{
    /// <summary>
    /// Food�࣬����Ʒ��
    /// </summary>
    public class Food
    {
        Hashtable food = new Hashtable();

        /// <summary>
        /// ���ʳƷ
        /// </summary>
        /// <param name="strName">ʳƷ����</param>
        /// <param name="Price">�۸�</param>
        public void Add(string strName, string Price)
        {
            food.Add(strName, Price);
        }

        /// <summary>
        /// ��ʾʳƷ�嵥
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
