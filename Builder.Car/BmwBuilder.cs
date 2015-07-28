using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder.Car
{
    public class BmwBuilder : CarBuilder
    {
        private BmwModel car = new BmwModel();

        public override CarModel GetCarModel()
        {
            return this.car;
        }

        public override void SetSequence(List<String> sequence)
        {
            this.car.SetSequence(sequence);
        }

    }
}
