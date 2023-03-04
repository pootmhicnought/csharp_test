using System;
using System.Collections.Generic;
using System.Linq;
using Perceptron.OCR.Model.Model.Abstract;

namespace Perceptron.OCR.Model.Model.Concrete
{
    internal class Pixels : List<IPixel>, IPixels
    {
        #region Constructor

        public Pixels()
        {
            for (int i = 0; i < 64; i++)
                Add(new Pixel());
        }

        public Pixels(IEnumerable<bool> pixels)
        {
            if (pixels == null)
                throw new ArgumentNullException();

            if (pixels.Count() != 64)
                throw new ArgumentOutOfRangeException();

            foreach (var pixel in pixels)
                Add(new Pixel(pixel));
        }

        #endregion
    }
}
