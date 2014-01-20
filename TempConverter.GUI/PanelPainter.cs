using System.Drawing;
using System.Windows.Forms;
using TempConverter.GUI.EventArgs;
using TempConverter.Model.Domain;

namespace TempConverter.GUI
{
    public class PanelPainter
    {
        public readonly int GraphBarHeight = 8;


        public PanelPainter(int graphBarHeight)
        {
            GraphBarHeight = graphBarHeight;
        }

        public void PaintFahrenheitPanel(PaintEventArgs e, Scale<int> scale)
        {
            var panelPaintArgs = e as PanelPaintEventArgs;
            if (panelPaintArgs == null) return;

            if (panelPaintArgs.Temperatures.Fahrenheit > 0)
            {
                RefreshPanelPaint(panelPaintArgs);
                panelPaintArgs.Graphics.FillRectangle(new SolidBrush(Color.Yellow), x: 0, y: 0,
                                                      width: (int) panelPaintArgs.Temperatures.Fahrenheit/
                                                             scale.ScaleBy, height: GraphBarHeight);
            }

            if (panelPaintArgs.Temperatures.Fahrenheit < 0)
            {
                RefreshPanelPaint(panelPaintArgs);
                panelPaintArgs.Graphics.FillRectangle(new SolidBrush(Color.Red), x: 0, y: 0,
                                                      width: (int) panelPaintArgs.Temperatures.Fahrenheit/
                                                             scale.ScaleBy*-1, height: GraphBarHeight);
            }
        }

        public void PaintCelsiusPanel(PaintEventArgs e, Scale<int> scale)
        {
            var panelPaintArgs = e as PanelPaintEventArgs;
            if (panelPaintArgs == null) return;

            if (panelPaintArgs.Temperatures.Celsius > 0)
            {
                RefreshPanelPaint(panelPaintArgs);
                panelPaintArgs.Graphics.FillRectangle(new SolidBrush(Color.Yellow), x: 0, y: 0,
                                                      width: (int) panelPaintArgs.Temperatures.Celsius/
                                                             scale.ScaleBy, height: GraphBarHeight);
            }

            if (panelPaintArgs.Temperatures.Celsius < 0)
            {
                RefreshPanelPaint(panelPaintArgs);
                panelPaintArgs.Graphics.FillRectangle(new SolidBrush(Color.Red), x: 0, y: 0,
                                                      width: (int) panelPaintArgs.Temperatures.Celsius/
                                                             scale.ScaleBy*-1, height: GraphBarHeight);
            }
        }

        public void PaintKelvinPanel(PaintEventArgs e, Scale<int> scale)
        {
            var panelPaintArgs = e as PanelPaintEventArgs;
            if (panelPaintArgs == null) return;

            if (panelPaintArgs.Temperatures.Kelvin > 0)
            {
                RefreshPanelPaint(panelPaintArgs);
                panelPaintArgs.Graphics.FillRectangle(new SolidBrush(Color.Yellow), x: 0, y: 0,
                                                      width: (int) panelPaintArgs.Temperatures.Kelvin/
                                                             scale.ScaleBy, height: GraphBarHeight);
            }

            if (panelPaintArgs.Temperatures.Kelvin < 0)
            {
                RefreshPanelPaint(panelPaintArgs);
                panelPaintArgs.Graphics.FillRectangle(new SolidBrush(Color.Red), x: 0, y: 0,
                                                      width: (int) panelPaintArgs.Temperatures.Kelvin/
                                                             scale.ScaleBy*-1, height: GraphBarHeight);
            }
        }

        private void RefreshPanelPaint(PaintEventArgs paintEventArgs)
        {
            paintEventArgs.Graphics.FillRectangle(new SolidBrush(Color.Black), x: 0, y: 0, width: 200, height: 8);
        }
    }
}