using System;

namespace DesignPatterns.Builder.KFC
{
    /// <summary>
    /// FoodManager�࣬��ָ����
    /// </summary>
    public class FoodManager
    {
        public void Construct(Builder builder)
        {
            builder.BuildHamb();

            builder.BuildCoke();

            builder.BuildChip();
        }
    }
}
