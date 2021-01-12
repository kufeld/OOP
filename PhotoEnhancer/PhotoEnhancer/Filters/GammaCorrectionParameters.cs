using System;

namespace PhotoEnhancer
{
    public class GammaCorrectionParameters : IParameters
    {
        [ParameterInfo(Name = "Гамма", MinValue = 0.2, MaxValue = 10, DefailtValue = 1, Increment = 0.01)]
        public double GammaParameter { get; set; }
    }
}
