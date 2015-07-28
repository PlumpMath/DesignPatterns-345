using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder.Car
{
    /// <summary>
    /// 奥迪车模型
    /// </summary>
    public class AudiModel : CarModel
    {
        protected override void Alarm()
        {
            Console.WriteLine("奥迪车的喇叭声音是这个样子的...");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("奥迪车的引擎室这个声音的...");
        }

        protected override void Start()
        {
            Console.WriteLine("奥迪车跑起来是这个样子的...");
        }

        protected override void Stop()
        {
            Console.WriteLine("奥迪车应该这样停车...");
        }

    }
}
