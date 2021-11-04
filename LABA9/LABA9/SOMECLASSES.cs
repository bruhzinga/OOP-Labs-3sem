using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA9
{
    internal class FullscreenWindow
    {
        private int Width;

        private int Hight;

        private float PercentageOfScreen = 100;

        public FullscreenWindow(int hight, int width)
        {
            Width = width;
            Hight = hight;
        }

        public void Squeeze(float factor)
        {
            PercentageOfScreen *= factor;
        }

        public override string ToString()
        {
            return $"Width = {Width} Hight = {Hight} Percentage = {PercentageOfScreen} ";
        }
    }

    internal class InWindowWindow
    {
        private int Width;

        private int Hight;

        private float PercentageOfScreen;

        private string Coords;

        public InWindowWindow(int hight, int width, int percentageOfScreen, string coords)
        {
            Width = width;
            Hight = hight;
            PercentageOfScreen = percentageOfScreen;
            Coords = coords;
        }

        public void Move(string coords)
        {
            Coords = coords;
        }

        public void Squeeze(float factor)
        {
            PercentageOfScreen *= factor;
        }

        public override string ToString()
        {
            return $"Width = {Width} Hight = {Hight} Percentage = {PercentageOfScreen} Coords = {Coords}";
        }
    }
}