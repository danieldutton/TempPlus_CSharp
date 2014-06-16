using System.Drawing;
using System.Windows.Forms;

namespace TempConverter.GUI
{
    public class PanelPainter
    {
        public const int GraphBarHeight = 8;

        public void PaintFahrenheitPanel(PaintEventArgs e, double temp)
        {
            if (temp > 0)
            {
                RefreshPanelPaint(e);
                e.Graphics.FillRectangle(new SolidBrush(Color.Yellow), x: 0, y: 0,
                    width: (int)temp/
                           3, height: GraphBarHeight);
            }

            if (temp < 0)
            {
                RefreshPanelPaint(e);
                e.Graphics.FillRectangle(new SolidBrush(Color.Red), x: 0, y: 0,
                    width: (int)temp/
                           3*-1, height: GraphBarHeight);
            }
        }

        private void RefreshPanelPaint(PaintEventArgs paintEventArgs)
        {
            paintEventArgs.Graphics.FillRectangle(new SolidBrush(Color.Black), x: 0, y: 0, width: 200, height: 8);
        }
    }
}