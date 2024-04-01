using System.Drawing;

namespace MyCv.Library
{
    class clsButtonColor
    {
        private const int mouseEnter = 1;
        private const int mouseDown = 2;
        private const int mouseClick = 3;

        private int[] gainsboro = { 220, 220, 220 };
        private int[] gray = { 128, 128, 128 };
        private int[] dimGray = { 105, 105, 105 };

        public int MouseEnter { get { return mouseEnter; } }
        public int MouseDown { get { return mouseDown; } }
        public int MouseClick { get { return mouseClick; } }

        public int[] Gainsboro { get { return gainsboro; } }
        public int[] Gray { get { return gray; } }
        public int[] DimGray { get { return dimGray; } }

        public Color Set(int[] colorPalette, int mouseEvent = 0, int degreeDarker = 0)
        {
            int degreeMouseEnter = 10;
            int degreeMouseDown = 15;
            int degreeMouseClick = 20;

            int i = 20 * degreeDarker;

            if (colorPalette == Gray)
            {
                degreeMouseEnter = 5;
                degreeMouseDown = 10;
                degreeMouseClick = 15;
            }

            switch (mouseEvent)
            {
                case mouseEnter:
                    return Color.FromArgb(colorPalette[0] - degreeMouseEnter - i, colorPalette[1] - degreeMouseEnter - i, colorPalette[2] - degreeMouseEnter - i);
                case mouseDown:
                    return Color.FromArgb(colorPalette[0] - degreeMouseDown - i, colorPalette[1] - degreeMouseDown - i, colorPalette[2] - degreeMouseDown - i);
                case mouseClick:
                    return Color.FromArgb(colorPalette[0] - degreeMouseClick - i, colorPalette[1] - degreeMouseClick - i, colorPalette[2] - degreeMouseClick - i);
                default:
                    return Color.FromArgb(colorPalette[0] - i, colorPalette[1] - i, colorPalette[2] - i);
            }
        }
    }
}