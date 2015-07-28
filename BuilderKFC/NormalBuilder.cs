using System;

namespace DesignPatterns.Builder.KFC
{
    /// <summary>
    /// NormalBuilder类，具体构造者，普通套餐
    /// </summary>
    public class NormalBuilder : Builder
    {
        private Food NormalFood = new Food();

        public override void BuildHamb()
        {
            NormalFood.Add("NormalHamb", "￥10.50");
        }

        public override void BuildCoke()
        {
            NormalFood.Add("CokeCole", "￥4.50");
        }

        public override void BuildChip()
        {
            NormalFood.Add("FireChips", "￥2.00");
        }

        public override Food GetFood()
        {
            return NormalFood;
        }

    }
}
