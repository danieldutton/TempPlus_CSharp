using System;
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

        private Scale<int> _scale;

        public NoFocusTrackBar(Scale<int> scale)
        {
            _scale = scale;
            Init();
        }

        private void Init()
        {
            SetRange(_scale.Minimum, _scale.Maximum);
            TickFrequency = 10;
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
