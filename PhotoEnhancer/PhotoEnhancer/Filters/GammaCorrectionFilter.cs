using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
            var origH = Convertors.GetPixelHue(originalPixel);
            var origS = Convertors.GetPixelSaturation(originalPixel);
            var origL = Convertors.GetPixelLightness(originalPixel);

            var newL = Math.Pow(origL, 1 / (parameters as GammaCorrectionParameters).GammaParameterByUser);
            return Convertors.HSL2Pixel(origH, origS, newL);

        }
    }
}
