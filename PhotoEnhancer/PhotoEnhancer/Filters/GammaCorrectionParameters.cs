using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    class GammaCorrectionParameters : IParameters
    {
        public double GammaParameterByUser { get; set; }
        public ParameterInfo[] GetDescription()
        {
            return new[]
            {
                new ParameterInfo() {
                    Name = "Гамма",
                    MinValue = 0.2,
                    MaxValue = 10,
                    DefailtValue = 1,
                    Increment = 0.01
                    }
            };
        }

        public void SetValues(double[] values)
        {
            GammaParameterByUser = values[0];
        }
    }
}
