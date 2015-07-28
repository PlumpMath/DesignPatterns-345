using System;

namespace DesignPatterns.Builder.KFC
{
    /// <summary>
    /// GoldBuilder类，具体构造者，黄金套餐
    /// </summary>
    public class GoldBuilder : Builder
    {
        private Food GoldFood = new Food();

        public override void BuildHamb()
        {
            GoldFood.Add("GoldHamb", "￥13.50");
        }

        public override void BuildCoke()
        {
            GoldFood.Add("CokeCole", "￥4.50");
        }

        public override void BuildChip()
        {
            GoldFood.Add("FireChips", "￥3.50");
        }

        public override Food GetFood()
        {
            return GoldFood;
        }

    }
}
