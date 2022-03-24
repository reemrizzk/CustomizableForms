using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomizableForms
{
    public class CustomizedMenuStrip : MenuStrip
    {
        bool dark = false;
        ToolStripProfessionalRenderer menuLightRenderer = new ToolStripProfessionalRenderer(new MenuRenderer());
        ToolStripProfessionalRenderer menuDarkRenderer = new ToolStripProfessionalRenderer(new DarkRenderer());
        public CustomizedMenuStrip()
        {
            this.Renderer =
            new ToolStripProfessionalRenderer(new MenuRenderer());
            this.Dock = DockStyle.Left;
            this.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
        }
        [Category("CustomizedUI"), Browsable(true), Description("DarkTheme")]
        public bool DarkTheme
        {
            get { return dark; }
            set
            {
                dark = value;
                if (dark)
                {
                    this.BackColor = Color.FromArgb(40, 40, 40);
                    this.ForeColor = Color.FromArgb(240, 240, 240);
                    this.Renderer = menuDarkRenderer;
                }
                else
                {
                    this.BackColor = Color.FromArgb(255, 255, 255);
                    this.ForeColor = Color.Black;
                    this.Renderer = menuLightRenderer;
                }
            }
        }

    }
}
