using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CustomizableForms.Properties;

namespace CustomizableForms
{
    public partial class CustomizableForm : Form
    {
        bool dark = false;
        bool formResizable = true;
        bool showMaximize = true;
        bool showMinimize = true;
        bool showIcon = true;
        bool showTitle = true;
        int formBorderWidth = 1;
        Color formBorderColor = Color.Gray;
        FormWindowState lastState = FormWindowState.Minimized;
        bool mLeft = false; bool mRight = false; bool mTop = false; bool mBottom = false;
        bool mTopLeft = false; bool mTopRight = false;
        bool mBottomLeft = false; bool mBottomRight = false;
        int xPos = 0; int yPos = 0; int currentWidth, currentHeight;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public CustomizableForm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.FormBorderStyle = FormBorderStyle.None;
            currentWidth = this.Width;
            currentHeight = this.Height;
            this.Text = "Title";
        }
        [Category("Appearance"), Browsable(true), Description("Text")]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                formTitle.Text = value;
            }
        }
        [Category("Window Style"), Browsable(true), Description("MaximizeBox")]
        public new bool MaximizeBox
        {
            get { return showMaximize; }
            set
            {
                showMaximize = value;
                if (showMaximize) { btnMaximize.Visible = true; }
                else { btnMaximize.Visible = false; }
            }
        }
        [Category("Window Style"), Browsable(true), Description("MinimizeBox")]
        public new bool MinimizeBox
        {
            get { return showMinimize; }
            set
            {
                showMinimize = value;
                if (showMinimize) { btnMinimize.Visible = true; }
                else { btnMinimize.Visible = false; }
            }
        }
        [Category("Window Style"), Browsable(true), Description("ShowIcon")]
        public new bool ShowIcon
        {
            get { return showIcon; }
            set
            {
                showIcon = value;
                if (showIcon) { formIcon.Visible = true; }
                else { formIcon.Visible = false; }
            }
        }
        [Category("Window Style"), Browsable(false), Description("HelpButton")]
        public new bool HelpButton
        { get; set; }

        [Category("CustomizableForm"), Browsable(true), Description("DarkTheme")]
        public bool DarkTheme
        {
            get { return dark; }
            set
            {
                dark = value;
                if (dark)
                {
                    formHeader.BackColor = Color.FromArgb(40, 40, 40);
                    formTitle.ForeColor = Color.FromArgb(240, 240, 240);
                    btnMinimize.Image = Resources.minimize_dark;
                    if (this.WindowState == FormWindowState.Maximized)
                        btnMaximize.Image = Resources.maximized_dark;
                    else
                        btnMaximize.Image = Resources.maximize_dark;
                    btnClose.Image = Resources.close_dark;


                }
                else
                {
                    formHeader.BackColor = Color.FromArgb(255, 255, 255);
                    formTitle.ForeColor = Color.Black;
                    btnMinimize.Image = Resources.minimize_light;
                    if (this.WindowState == FormWindowState.Maximized)
                        btnMaximize.Image = Resources.maximized_light;
                    else
                        btnMaximize.Image = Resources.maximize_light;
                    btnClose.Image = Resources.close_light;

                    foreach (Control ms in formHeader.Controls)
                    {
                        if (ms is MenuStrip)
                        {
                            ms.BackColor = Color.FromArgb(255, 255, 255);
                            ms.ForeColor = Color.Black;

                        }
                    }
                }
            }
        }
        [Category("CustomizableForm"), Browsable(true), Description("Resizable")]
        public bool Resizable
        {
            get { return formResizable; }
            set
            {
                formResizable = value;
                if (formResizable)
                {
                    borderRight.Cursor = Cursors.SizeWE;
                    borderBottom.Cursor = Cursors.SizeNS;
                    borderLeft.Cursor = Cursors.SizeWE;
                    borderTop.Cursor = Cursors.SizeNS; 
                    borderTopRight.Cursor = Cursors.SizeNESW;
                    borderBottomRight.Cursor = Cursors.SizeNWSE;
                    borderTopLeft.Cursor = Cursors.SizeNWSE;
                    borderBottomLeft.Cursor = Cursors.SizeNESW;
                }
                else
                {
                    borderRight.Cursor = Cursors.Default;
                    borderBottom.Cursor = Cursors.Default;
                    borderLeft.Cursor = Cursors.Default;
                    borderTop.Cursor = Cursors.Default;
                    borderTopRight.Cursor = Cursors.Default;
                    borderBottomRight.Cursor = Cursors.Default;
                    borderTopLeft.Cursor = Cursors.Default;
                    borderBottomLeft.Cursor = Cursors.Default;
                }

            }
        }

        [Category("CustomizableForm"), Browsable(true), Description("BorderWidth")]
        public int BorderWidth
        {
            get { return formBorderWidth; }
            set
            {
                if (value < 6 && value >= 0)
                {
                    formBorderWidth = value;
                    borderTop.Height = value;
                    borderBottom.Height = value;
                    borderLeft.Width = value;
                    borderRight.Width = value;
                    borderTopLeft.Height = value;
                    borderTopRight.Height = value;
                    borderBottomLeft.Height = value;
                    borderBottomRight.Height = value;
                }
                else if (value >= 6) { formBorderWidth = 5; }
                else { formBorderWidth = 0; }
            }
        }


        [Category("CustomizableForm"), Browsable(true), Description("BorderColor")]
        public Color BorderColor
        {
            get { return formBorderColor; }
            set
            {
                formBorderColor = value;
                borderTop.BackColor = value;
                borderBottom.BackColor = value;
                borderLeft.BackColor = value;
                borderRight.BackColor = value;
                borderTopLeft.BackColor = value;
                borderTopRight.BackColor = value;
                borderBottomLeft.BackColor = value;
                borderBottomRight.BackColor = value;

            }
        }
        [Category("CustomizableForm"), Browsable(true), Description("ShowTitle")]
        public bool ShowTitle
        {
            get { return showTitle; }
            set
            {
                showTitle = value;
                if (showTitle) { formTitle.Visible = true; }
                else { formTitle.Visible = false; }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void headerPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            { this.WindowState = FormWindowState.Normal; }
            else { this.WindowState = FormWindowState.Maximized; }
        }

        private void DynamicForm_TextChanged(object sender, EventArgs e)
        {

        }

        private void DynamicForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState != lastState)
            {
                lastState = WindowState;
                if (this.WindowState == FormWindowState.Normal)
                {
                    if (dark) btnMaximize.Image = Resources.maximize_dark;
                    else btnMaximize.Image = Resources.maximize_light;
                    borderTop.Visible = true;
                    borderLeft.Visible = true;
                    borderRight.Visible = true;
                    borderBottom.Visible = true;
                    borderTopLeft.Visible = true;
                    borderTopRight.Visible = true;
                    borderBottomLeft.Visible = true;
                    borderBottomRight.Visible = true;
                }
                else if (this.WindowState == FormWindowState.Maximized)
                {
                    if (dark) btnMaximize.Image = Resources.maximized_dark;
                    else btnMaximize.Image = Resources.maximized_light;
                    borderTop.Visible = false;
                    borderLeft.Visible = false;
                    borderRight.Visible = false;
                    borderBottom.Visible = false;
                    borderTopLeft.Visible = false;
                    borderTopRight.Visible = false;
                    borderBottomLeft.Visible = false;
                    borderBottomRight.Visible = false;
                }
            }
        }
        private void formIcon_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawIcon(this.Icon, 8, 8);
        }
        private void formTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region Right border
        private void borderRight_MouseDown(object sender, MouseEventArgs e)
        {
            mRight = true;
            xPos = Cursor.Position.X;
            currentWidth = this.Width;
            borderRight.BringToFront();
            formHeader.BringToFront();
        }
        private void borderRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (mRight && formResizable)
            {
                if (currentWidth + (Cursor.Position.X - xPos) > (135 + formBorderWidth))
                {
                    this.Width = currentWidth + (Cursor.Position.X - xPos);
                }
            }
        }

        private void borderRight_MouseUp(object sender, MouseEventArgs e)
        {
            mRight = false;
        }
        #endregion
        #region Bottom border
        private void borderBottom_MouseDown(object sender, MouseEventArgs e)
        {
            mBottom = true;
            yPos = Cursor.Position.Y;
            currentHeight = this.Height;
            borderBottom.BringToFront();
            borderLeft.BringToFront();
            borderRight.BringToFront();
            formHeader.BringToFront();
        }
        private void borderBottom_MouseMove(object sender, MouseEventArgs e)
        {
            if (mBottom && formResizable)
            {
                if (currentHeight + (Cursor.Position.Y - yPos) > (31 + formBorderWidth))
                {
                    this.Height = currentHeight + (Cursor.Position.Y - yPos);
                }
            }
        }
        private void borderBottom_MouseUp(object sender, MouseEventArgs e)
        {
            mBottom = false;
        }
        #endregion
        #region Left border
        private void borderLeft_MouseDown(object sender, MouseEventArgs e)
        {
            mLeft = true;
            xPos = Cursor.Position.X;
            currentWidth = this.Width;
            borderRight.BringToFront();
            formHeader.BringToFront();
        }

        private void borderLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (mLeft && formResizable)
            {
                if (currentWidth + (xPos - Cursor.Position.X) > (135 + formBorderWidth))
                {
                    this.Left = Cursor.Position.X;
                    this.Width = currentWidth + (xPos - Cursor.Position.X);
                }
            }
        }
        private void borderLeft_MouseUp(object sender, MouseEventArgs e)
        {
            mLeft = false;
        }
        #endregion
        #region Top border
        private void borderTop_MouseDown(object sender, MouseEventArgs e)
        {
            mTop = true;
            yPos = Cursor.Position.Y;
            currentHeight = this.Height;
            borderBottom.BringToFront();
            borderTop.BringToFront();
            borderLeft.BringToFront();
            borderRight.BringToFront();
            formHeader.BringToFront();
        }

        private void borderTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mTop && formResizable)
            {
                if (currentHeight + (yPos - Cursor.Position.Y) > (31 + formBorderWidth))
                {
                    this.Top = Cursor.Position.Y;
                    this.Height = currentHeight + (yPos - Cursor.Position.Y);
                }
            }
        }
        private void borderTop_MouseUp(object sender, MouseEventArgs e)
        {
            mTop = false;
        }
        #endregion
        #region Border top left  
        private void borderTopLeft_MouseDown(object sender, MouseEventArgs e)
        {
            mTopLeft = true;
            xPos = Cursor.Position.X;
            yPos = Cursor.Position.Y;
            currentWidth = this.Width;
            currentHeight = this.Height;
            borderBottom.BringToFront();
            borderLeft.BringToFront();
            borderRight.BringToFront();
            formHeader.BringToFront();
        }
        private void borderTopLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (mTopLeft && formResizable)
            {
                if (currentWidth + (xPos - Cursor.Position.X) > (135 + formBorderWidth))
                {
                    this.Left = Cursor.Position.X;
                    this.Width = currentWidth + (xPos - Cursor.Position.X);
                }
                if (currentHeight + (yPos - Cursor.Position.Y) > (31 + formBorderWidth))
                {
                    this.Top = Cursor.Position.Y;
                    this.Height = currentHeight + (yPos - Cursor.Position.Y);
                }
            }
        }
        private void borderTopLeft_MouseUp(object sender, MouseEventArgs e)
        {
            mTopLeft = false;
        }
        #endregion
        #region Border top right
        private void borderTopRight_MouseDown(object sender, MouseEventArgs e)
        {
            mTopRight = true;
            xPos = Cursor.Position.X;
            yPos = Cursor.Position.Y;
            currentWidth = this.Width;
            currentHeight = this.Height;
            borderBottom.BringToFront();
            borderLeft.BringToFront();
            borderRight.BringToFront();
            formHeader.BringToFront();
        }
        private void borderTopRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (mTopRight && formResizable)
            {
                if (currentWidth + (Cursor.Position.X - xPos) > (135 + formBorderWidth))
                {
                    this.Width = currentWidth + (Cursor.Position.X - xPos);
                }
                if (currentHeight + (yPos - Cursor.Position.Y) > (31 + formBorderWidth))
                {
                    this.Top = Cursor.Position.Y;
                    this.Height = currentHeight + (yPos - Cursor.Position.Y);
                }
            }
        }
        private void borderTopRight_MouseUp(object sender, MouseEventArgs e)
        {
            mTopRight = false;
        }
        #endregion
        #region Border bottom left
        private void borderBottomLeft_MouseDown(object sender, MouseEventArgs e)
        {
            mBottomLeft = true;
            xPos = Cursor.Position.X;
            yPos = Cursor.Position.Y;
            currentWidth = this.Width;
            currentHeight = this.Height;
            borderBottom.BringToFront();
            borderLeft.BringToFront();
            borderRight.BringToFront();
            formHeader.BringToFront();
        }

        private void borderBottomLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (mBottomLeft && formResizable)
            {
                if (currentWidth + (xPos - Cursor.Position.X) > (135 + formBorderWidth))
                {
                    this.Left = Cursor.Position.X;
                    this.Width = currentWidth + (xPos - Cursor.Position.X);
                }
                if (currentHeight + (Cursor.Position.Y - yPos) > (31 + formBorderWidth))
                {
                    this.Height = currentHeight + (Cursor.Position.Y - yPos);
                }
            }
        }
        private void borderBottomLeft_MouseUp(object sender, MouseEventArgs e)
        {
            mBottomLeft = false;
        }
        #endregion
        #region Border bottom right
        private void borderBottomRight_MouseDown(object sender, MouseEventArgs e)
        {
            mBottomRight = true;
            xPos = Cursor.Position.X;
            yPos = Cursor.Position.Y;
            currentWidth = this.Width;
            currentHeight = this.Height;
            borderBottom.BringToFront();
            borderLeft.BringToFront();
            borderRight.BringToFront();
            formHeader.BringToFront();
        }

        private void borderBottomRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (mBottomRight && formResizable)
            {
                if (currentWidth + (Cursor.Position.X - xPos) > (135 + formBorderWidth))
                {
                    this.Width = currentWidth + (Cursor.Position.X - xPos);
                }
                if (currentHeight + (Cursor.Position.Y - yPos) > (31 + formBorderWidth))
                {
                    this.Height = currentHeight + (Cursor.Position.Y - yPos);
                }
            }
        }

        private void borderBottomRight_MouseUp(object sender, MouseEventArgs e)
        {
            mBottomRight = false;
        }
        #endregion
        
    }
}
