using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder.Car
{
    /// <summary>
    /// 宝马车模型
    /// </summary>
    public class BmwModel : CarModel   
    {
        protected override void Alarm()
        {
            Console.WriteLine("宝马车的喇叭声音是这个样子的...");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("宝马车的引擎室这个声音的...");
        }

        protected override void Start()
        {
            Console.WriteLine("宝马车跑起来是这个样子的...");
        }

        protected override void Stop()
        {
            Console.WriteLine("宝马车应该这样停车...");
        }
    }
}
