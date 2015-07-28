using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder.Car
{
    public abstract class CarModel
    {
        //这个参数是各个基本方法执行的顺序
        private List<String> sequence = new List<String>();

        /*
         * 模型是启动开始跑了
         */
        protected abstract void Start();

        //能发动，那还要能停下来，那才是真本事
        protected abstract void Stop();

        //喇叭会出声音，是滴滴叫，还是哔哔叫
        protected abstract void Alarm();

        //引擎会轰隆隆的响，不响那是假的
        protected abstract void EngineBoom();

        //那模型应该会跑吧，别管是人推的，还是电力驱动，总之要会跑
        public void Run()
        {

            //循环一边，谁在前，就先执行谁
            for (int i = 0; i < this.sequence.Count; i++)
            {
                String actionName = this.sequence[i];

                if (actionName.ToLower().Equals("start"))
                {  
                    //如果是start关键字，
                    this.Start();  //开启汽车
                }
                else if (actionName.ToLower().Equals("stop"))
                { 
                    //如果是stop关键字
                    this.Stop(); //停止汽车   
                }
                else if (actionName.ToLower().Equals("alarm"))
                { 
                    //如果是alarm关键字
                    this.Alarm(); //喇叭开始叫了
                }
                else if (actionName.ToLower().Equals("engine boom"))
                {  
                    //如果是engine boom关键字
                    this.EngineBoom();  //引擎开始轰鸣
                }
            }
        }

        //把传递过来的值传递到类内
        public void SetSequence(List<String> sequence)
        {
            this.sequence = sequence;
        }
    }
}
