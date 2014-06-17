using System.Drawing;
using System.Windows.Forms;

namespace TempConverter.GUI
{
    //get rid of magic numbers
    //unit test it
    //is it a lazy class
    public class PanelPainter
    {
        private const int GraphBarHeight = 8;

        private const int XPos = 0;

        private const int YPos = 0;

        public void PaintPanels(PaintEventArgs _paintEventArgs, double temp)
        {
            if (temp >= 0)
            {
                RefreshPanelPaint(_paintEventArgs);
                _paintEventArgs.Graphics.FillRectangle(new SolidBrush(Color.Yellow), XPos, YPos,
                    width: (int)temp/
                           3, height: GraphBarHeight);
            }

            if (temp < 0)
            {
                RefreshPanelPaint(_paintEventArgs);
                _paintEventArgs.Graphics.FillRectangle(new SolidBrush(Color.Red), XPos, YPos,
                    width: (int)temp/
                           3*-1, height: GraphBarHeight);
            }
        }

        private void RefreshPanelPaint(PaintEventArgs paintEventArgs)
        {
            paintEventArgs.Graphics.FillRectangle(new SolidBrush(Color.Black), XPos, YPos, width: 200, height: GraphBarHeight);
        }  
    }
}