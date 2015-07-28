using System;

namespace DesignPatterns.Builder.KFC
{
    /// <summary>
    /// Builder类，即抽象建造者类，构造套餐
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// 添加汉堡
        /// </summary>
        public abstract void BuildHamb();

        /// <summary>
        /// 添加可乐
        /// </summary>
        public abstract void BuildCoke();

        /// <summary>
        /// 添加薯条
        /// </summary>
        public abstract void BuildChip();

        /// <summary>
        /// 返回结果
        /// </summary>
        /// <returns>食品对象</returns>
        public abstract Food GetFood();
    }
}
