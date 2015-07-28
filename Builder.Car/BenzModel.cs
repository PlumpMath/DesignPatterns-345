using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder.Car
{
    /// <summary>
    /// 奔驰车模型
    /// </summary>
    public class BenzModel : CarModel
    {
        protected override void Alarm()
        {
            Console.WriteLine("奔驰车的喇叭声音是这个样子的...");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("奔驰车的引擎室这个声音的...");
        }

        protected override void Start()
        {
            Console.WriteLine("奔驰车跑起来是这个样子的...");
        }

        protected override void Stop()
        {
            Console.WriteLine("奔驰车应该这样停车...");
        }

    }
}
