using System.Drawing;
using System.Windows.Forms;
using TempConverter.Model.Domain;

namespace TempConverter.GUI.EventArgs
{
    public sealed class PanelPaintEventArgs : PaintEventArgs
    {
        public Temperature<double> Temperatures { get; private set; }

        public PanelPaintEventArgs(Graphics graphics, Temperature<double> temperature) 
            : this(graphics, new Rectangle())
        {
            Temperatures = temperature;
        }

        public PanelPaintEventArgs(Graphics graphics, Rectangle clipRect) 
            : base(graphics, clipRect)
        {
        }

    }
}
