using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoEnhancer
{
    class GammaCorrectionFilter : PixelFilter
    {
        public GammaCorrectionFilter() : base(new GammaCorrectionParameters()) { }

        public override string ToString()
        {
            return "Гамма-коррекция";
        }

        public override Pixel ProcessPixel(Pixel originalPixel, IParameters parameters)
        {
            
        }
    }
}
