
namespace CustomizableForms
{
    partial class CustomizableForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.formHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.formTitle = new System.Windows.Forms.Label();
            this.formIcon = new System.Windows.Forms.PictureBox();
            this.borderLeft = new System.Windows.Forms.Panel();
            this.borderTopLeft = new System.Windows.Forms.Panel();
            this.borderBottomLeft = new System.Windows.Forms.Panel();
            this.borderRight = new System.Windows.Forms.Panel();
            this.borderBottomRight = new System.Windows.Forms.Panel();
            this.borderTopRight = new System.Windows.Forms.Panel();
            this.borderBottom = new System.Windows.Forms.Panel();
            this.borderTop = new System.Windows.Forms.Panel();
            this.formHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formIcon)).BeginInit();
            this.borderLeft.SuspendLayout();
            this.borderRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // formHeader
            // 
            this.formHeader.BackColor = System.Drawing.Color.Transparent;
            this.formHeader.Controls.Add(this.btnMinimize);
            this.formHeader.Controls.Add(this.btnMaximize);
            this.formHeader.Controls.Add(this.btnClose);
            this.formHeader.Controls.Add(this.formTitle);
            this.formHeader.Controls.Add(this.formIcon);
            this.formHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.formHeader.Location = new System.Drawing.Point(1, 1);
            this.formHeader.Margin = new System.Windows.Forms.Padding(0);
            this.formHeader.Name = "formHeader";
            this.formHeader.Size = new System.Drawing.Size(693, 32);
            this.formHeader.TabIndex = 0;
            this.formHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerPanel_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::CustomizableForms.Properties.Resources.minimize_light;
            this.btnMinimize.Location = new System.Drawing.Point(552, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(47, 32);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::CustomizableForms.Properties.Resources.maximized_light;
            this.btnMaximize.Location = new System.Drawing.Point(599, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(47, 32);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::CustomizableForms.Properties.Resources.close_light;
            this.btnClose.Location = new System.Drawing.Point(646, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(47, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.formTitle.Location = new System.Drawing.Point(32, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.formTitle.Size = new System.Drawing.Size(0, 31);
            this.formTitle.TabIndex = 5;
            this.formTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formTitle_MouseMove);
            // 
            // formIcon
            // 
            this.formIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.formIcon.Location = new System.Drawing.Point(0, 0);
            this.formIcon.Name = "formIcon";
            this.formIcon.Size = new System.Drawing.Size(32, 32);
            this.formIcon.TabIndex = 4;
            this.formIcon.TabStop = false;
            this.formIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.formIcon_Paint);
            // 
            // borderLeft
            // 
            this.borderLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.borderLeft.Controls.Add(this.borderTopLeft);
            this.borderLeft.Controls.Add(this.borderBottomLeft);
            this.borderLeft.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.borderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderLeft.Location = new System.Drawing.Point(0, 0);
            this.borderLeft.Name = "borderLeft";
            this.borderLeft.Size = new System.Drawing.Size(1, 528);
            this.borderLeft.TabIndex = 0;
            this.borderLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderLeft_MouseDown);
            this.borderLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderLeft_MouseMove);
            this.borderLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderLeft_MouseUp);
            // 
            // borderTopLeft
            // 
            this.borderTopLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.borderTopLeft.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.borderTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderTopLeft.Location = new System.Drawing.Point(0, 0);
            this.borderTopLeft.Name = "borderTopLeft";
            this.borderTopLeft.Size = new System.Drawing.Size(1, 1);
            this.borderTopLeft.TabIndex = 3;
            this.borderTopLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderTopLeft_MouseDown);
            this.borderTopLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderTopLeft_MouseMove);
            this.borderTopLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderTopLeft_MouseUp);
            // 
            // borderBottomLeft
            // 
            this.borderBottomLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.borderBottomLeft.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.borderBottomLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderBottomLeft.Location = new System.Drawing.Point(0, 527);
            this.borderBottomLeft.Name = "borderBottomLeft";
            this.borderBottomLeft.Size = new System.Drawing.Size(1, 1);
            this.borderBottomLeft.TabIndex = 2;
            this.borderBottomLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderBottomLeft_MouseDown);
            this.borderBottomLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderBottomLeft_MouseMove);
            this.borderBottomLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderBottomLeft_MouseUp);
            // 
            // borderRight
            // 
            this.borderRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.borderRight.Controls.Add(this.borderBottomRight);
            this.borderRight.Controls.Add(this.borderTopRight);
            this.borderRight.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.borderRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.borderRight.Location = new System.Drawing.Point(694, 0);
            this.borderRight.Name = "borderRight";
            this.borderRight.Size = new System.Drawing.Size(1, 528);
            this.borderRight.TabIndex = 0;
            this.borderRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderRight_MouseDown);
            this.borderRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderRight_MouseMove);
            this.borderRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderRight_MouseUp);
            // 
            // borderBottomRight
            // 
            this.borderBottomRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.borderBottomRight.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.borderBottomRight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderBottomRight.Location = new System.Drawing.Point(0, 527);
            this.borderBottomRight.Name = "borderBottomRight";
            this.borderBottomRight.Size = new System.Drawing.Size(1, 1);
            this.borderBottomRight.TabIndex = 5;
            this.borderBottomRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderBottomRight_MouseDown);
            this.borderBottomRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderBottomRight_MouseMove);
            this.borderBottomRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderBottomRight_MouseUp);
            // 
            // borderTopRight
            // 
            this.borderTopRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.borderTopRight.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.borderTopRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderTopRight.Location = new System.Drawing.Point(0, 0);
            this.borderTopRight.Name = "borderTopRight";
            this.borderTopRight.Size = new System.Drawing.Size(1, 1);
            this.borderTopRight.TabIndex = 4;
            this.borderTopRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderTopRight_MouseDown);
            this.borderTopRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderTopRight_MouseMove);
            this.borderTopRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderTopRight_MouseUp);
            // 
            // borderBottom
            // 
            this.borderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.borderBottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.borderBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderBottom.Location = new System.Drawing.Point(1, 527);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(693, 1);
            this.borderBottom.TabIndex = 0;
            this.borderBottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderBottom_MouseDown);
            this.borderBottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderBottom_MouseMove);
            this.borderBottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderBottom_MouseUp);
            // 
            // borderTop
            // 
            this.borderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.borderTop.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.borderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderTop.Location = new System.Drawing.Point(1, 0);
            this.borderTop.Name = "borderTop";
            this.borderTop.Size = new System.Drawing.Size(693, 1);
            this.borderTop.TabIndex = 0;
            this.borderTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.borderTop_MouseDown);
            this.borderTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.borderTop_MouseMove);
            this.borderTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.borderTop_MouseUp);
            // 
            // CustomizableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 528);
            this.Controls.Add(this.formHeader);
            this.Controls.Add(this.borderTop);
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.borderRight);
            this.Controls.Add(this.borderLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomizableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.DynamicForm_TextChanged);
            this.Resize += new System.EventHandler(this.DynamicForm_Resize);
            this.formHeader.ResumeLayout(false);
            this.formHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formIcon)).EndInit();
            this.borderLeft.ResumeLayout(false);
            this.borderRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel borderLeft;
        protected System.Windows.Forms.Panel formHeader;
        private System.Windows.Forms.Panel borderRight;
        private System.Windows.Forms.Panel borderBottom;
        private System.Windows.Forms.Panel borderTop;
        private System.Windows.Forms.PictureBox formIcon;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Panel borderTopLeft;
        private System.Windows.Forms.Panel borderBottomLeft;
        private System.Windows.Forms.Panel borderBottomRight;
        private System.Windows.Forms.Panel borderTopRight;
    }
}

