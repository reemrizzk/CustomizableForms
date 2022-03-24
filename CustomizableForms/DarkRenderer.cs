using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomizableForms
{
    class DarkRenderer : ProfessionalColorTable
    {
       
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(40,120,255); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(40, 120, 255); }
        }
        
        public override Color MenuItemBorder
        {
            get { return Color.FromArgb(40, 120, 255); }
        }
        
        public override Color MenuBorder
        {
            get { return Color.FromArgb(29, 29, 29); }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.FromArgb(70,70,70); }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.FromArgb(70,70,70); }
        }
        public override Color ToolStripGradientBegin
        {
            get { return Color.FromArgb(42, 42, 42); }
        }
        public override Color ToolStripGradientEnd
        {
            get { return Color.FromArgb(42, 42, 42); }
        }
        public override Color ToolStripGradientMiddle
        {
            get { return Color.FromArgb(42, 42, 42); }
        }
    }
}

