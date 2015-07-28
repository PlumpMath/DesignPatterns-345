using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder.Car
{
    /// <summary>
    /// 要什么顺序的车，你说，我给建造出来
    /// </summary>
    public abstract class CarBuilder
    {

        //建造一个模型，你要给我一个顺序要，就是组装顺序
        public abstract void SetSequence(List<String> sequence);

        //设置完毕顺序后，就可以直接拿到这个这两模型
        public abstract CarModel GetCarModel();
    }
}
