using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.BuilderPattern
{
    public class Director
    {
        /// <summary>
        /// Builder uses a complex series of steps
        /// </summary>
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
