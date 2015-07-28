using System;

namespace DesignPatterns.Builder.KFC
{
    /// <summary>
    /// FoodManager类，即指导者
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
