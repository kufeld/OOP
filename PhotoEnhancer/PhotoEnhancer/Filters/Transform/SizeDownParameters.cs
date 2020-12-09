using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    public class SizeDownParameters : IParameters
    {
        public double SizeDownParameter { get; set; }

        public ParameterInfo[] GetDescription()
        {
            return new[]
            {
                new ParameterInfo() {
                    Name = "Коэффициент уменьшения",
                    MinValue = 1,
                    MaxValue = 10,
                    DefailtValue = 1,
                    Increment = 0.5
                    }
            };
        }
        public void SetValues(double[] values)
        {
            SizeDownParameter = values[0];
        }
    }
}
