using System;
using System.Drawing;
using System.Windows.Forms;
using TempConverter.Model.Domain;

namespace TempConverter.GUI.Components
{
    /// <summary>
    /// TrackBar control but removes onFocus tab abilities
    /// </summary>
    public class NoFocusTrackBar : TrackBar
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public extern static int SendMessage(IntPtr hWnd, uint msg, int wParam, int lParam);

        private readonly Scale<int> _tempScale;

        public Scale<int> TempScale{get { return _tempScale; }} 

        public NoFocusTrackBar(Scale<int> scale)
        {
            _tempScale = scale;
            Init();
        }

        private void Init()
        {
            SetRange(TempScale.Minimum, TempScale.Maximum);
            TickFrequency = 10;
            Location = new Point(x: 8,y: 9);
            Size = new Size(width: 293, height: 45);
        }

        private static int MakeParam(int loWord, int hiWord)
        {
            return (hiWord << 16) | (loWord & 0xffff);
        }

        protected override void OnGotFocus(System.EventArgs e)
        {
            base.OnGotFocus(e);
            SendMessage(Handle, 0x0128, MakeParam(1, 0x1), 0);
        }

    }
}
