using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ShortURLCreator
{
    public class TextBoxExtended : System.Windows.Forms.TextBox
    {
        #region Unmanaged Methods
        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("user32", CharSet = CharSet.Auto)]
        private extern static int SendMessage(
            IntPtr hwnd,
            int wMsg,
            int wParam,
            int lParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindowEx(
            IntPtr hwndParent,
            IntPtr hwndChildAfter,
            [MarshalAs(UnmanagedType.LPTStr)]
			string lpszClass,
            [MarshalAs(UnmanagedType.LPTStr)]
			string lpszWindow);

        [DllImport("user32", CharSet = CharSet.Auto)]
        private extern static int GetWindowLong(
            IntPtr hWnd,
            int dwStyle);

        [DllImport("user32")]
        private extern static IntPtr GetDC(
            IntPtr hwnd);

        [DllImport("user32")]
        private extern static int ReleaseDC(
            IntPtr hwnd,
            IntPtr hdc);

        [DllImport("user32")]
        private extern static int GetClientRect(
            IntPtr hwnd,
            ref RECT rc);

        [DllImport("user32")]
        private extern static int GetWindowRect(
            IntPtr hwnd,
            ref RECT rc);

        private const int EC_LEFTMARGIN = 0x1;
        private const int EC_RIGHTMARGIN = 0x2;
        private const int EC_USEFONTINFO = 0xFFFF;
        private const int EM_SETMARGINS = 0xD3;
        private const int EM_GETMARGINS = 0xD4;

        private const int WM_PAINT = 0xF;

        private const int WM_SETFOCUS = 0x7;
        private const int WM_KILLFOCUS = 0x8;

        private const int WM_SETFONT = 0x30;

        private const int WM_MOUSEMOVE = 0x200;
        private const int WM_LBUTTONDOWN = 0x201;
        private const int WM_RBUTTONDOWN = 0x204;
        private const int WM_MBUTTONDOWN = 0x207;
        private const int WM_LBUTTONUP = 0x202;
        private const int WM_RBUTTONUP = 0x205;
        private const int WM_MBUTTONUP = 0x208;
        private const int WM_LBUTTONDBLCLK = 0x203;
        private const int WM_RBUTTONDBLCLK = 0x206;
        private const int WM_MBUTTONDBLCLK = 0x209;

        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const int WM_CHAR = 0x0102;

        private const int GWL_EXSTYLE = (-20);
        private const int WS_EX_RIGHT = 0x00001000;
        private const int WS_EX_LEFT = 0x00000000;
        private const int WS_EX_RTLREADING = 0x00002000;
        private const int WS_EX_LTRREADING = 0x00000000;
        private const int WS_EX_LEFTSCROLLBAR = 0x00004000;
        private const int WS_EX_RIGHTSCROLLBAR = 0x00000000;

        #endregion

        #region Private Fields

        private Image mImage;
        private Panel panel1;

        #endregion

        #region Events

        public event EventHandler ImageClick;

        #endregion

        #region Properties

        public Image Image
        {
            get { return mImage; }
            set 
            { 
                mImage = value;
                panel1.Refresh();
            }
        }

        #endregion

        #region Constructors

        public TextBoxExtended()
        {
            panel1 = new Panel() { Size = new Size(16, 16), BackColor = Color.FromArgb(0, 0, 0, 0) };
            panel1.MouseEnter += new EventHandler(panel_MouseEnter);
            panel1.Paint += new PaintEventHandler(panel_Paint);
            panel1.MouseDown += new MouseEventHandler(panel_MouseDown);
            NearMargin(this.Handle, 18, EC_LEFTMARGIN);
            this.Controls.Add(panel1);
        }

        #endregion

        #region Methods

        private static void NearMargin(IntPtr handle, int margin, int message)
        {
            if (message == EC_LEFTMARGIN)
            {
                margin = margin & 0xFFFF;
            }
            else
            {
                margin = margin * 0x10000;
            }
            SendMessage(handle, EM_SETMARGINS, message, margin);
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.Cursor = Cursors.Default;
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            if (!DesignMode && mImage != null)
                e.Graphics.DrawImage(mImage, new Point(0, 0));
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            OnImageClick(EventArgs.Empty);   
        }

        protected virtual void OnImageClick(EventArgs e)
        {
            if (ImageClick != null)
                ImageClick(this, e);
        }

        #endregion
    }
}
