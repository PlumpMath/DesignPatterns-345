using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Human
{
    /**
     * 女娲建立起了两条生产线，分别是：
     * 男性生产线
     * 女性生产线
     */
    public class NvWa
    {
        public static void Main(string[] args)
        {

            //第一条生产线，男性生产线
            HumanFactory maleHumanFactory = new MaleFactory();

            //第二条生产线，女性生产线
            HumanFactory femaleHumanFactory = new FemaleFactory();

            //生产线建立完毕，开始生产人了:
            Human maleYellowHuman = maleHumanFactory.CreateYellowHuman();

            Human femaleYellowHuman = femaleHumanFactory.CreateYellowHuman();


            Console.WriteLine("---生产一个黄色女性---");
            femaleYellowHuman.GetColor();
            femaleYellowHuman.Talk();
            femaleYellowHuman.GetSex();

            Console.WriteLine("---生产一个黄色男性---");
            maleYellowHuman.GetColor();
            maleYellowHuman.Talk();
            maleYellowHuman.GetSex();


            /*
             * .....
             * 后面你可以续了
             */
        }
    }

}
