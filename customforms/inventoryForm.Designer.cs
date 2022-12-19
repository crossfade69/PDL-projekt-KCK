namespace customforms
{
    partial class inventoryForm
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
            this.components = new System.ComponentModel.Container();
            this.downpanel = new System.Windows.Forms.Panel();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uppanel = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventorylistBox = new System.Windows.Forms.ListBox();
            this.inventorylabel = new System.Windows.Forms.Label();
            this.labelpanel = new System.Windows.Forms.Panel();
            this.close = new customforms.ButtonZ();
            this.max = new customforms.MinMaxButton();
            this.min = new customforms.ButtonZ();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.labelpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // downpanel
            // 
            this.downpanel.BackColor = System.Drawing.Color.Lavender;
            this.downpanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.downpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.downpanel.Location = new System.Drawing.Point(0, 580);
            this.downpanel.Name = "downpanel";
            this.downpanel.Size = new System.Drawing.Size(980, 3);
            this.downpanel.TabIndex = 0;
            this.downpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.downpanel_MouseDown);
            this.downpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.downpanel_MouseMove);
            this.downpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.downpanel_MouseUp);
            // 
            // rightpanel
            // 
            this.rightpanel.BackColor = System.Drawing.Color.Lavender;
            this.rightpanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightpanel.Location = new System.Drawing.Point(978, 0);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(2, 580);
            this.rightpanel.TabIndex = 2;
            this.rightpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rightpanel_MouseDown);
            this.rightpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.rightpanel_MouseMove);
            this.rightpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rightpanel_MouseUp);
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.Lavender;
            this.leftpanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(2, 580);
            this.leftpanel.TabIndex = 3;
            this.leftpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.leftpanel_MouseDown);
            this.leftpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.leftpanel_MouseMove);
            this.leftpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.leftpanel_MouseUp);
            // 
            // uppanel
            // 
            this.uppanel.BackColor = System.Drawing.Color.Lavender;
            this.uppanel.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.uppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uppanel.Location = new System.Drawing.Point(0, 0);
            this.uppanel.Name = "uppanel";
            this.uppanel.Size = new System.Drawing.Size(980, 3);
            this.uppanel.TabIndex = 1;
            this.uppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uppanel_MouseDown);
            this.uppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uppanel_MouseMove);
            this.uppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uppanel_MouseUp);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.MediumPurple;
            this.panel.Controls.Add(this.panel1);
            this.panel.Controls.Add(this.labelpanel);
            this.panel.Controls.Add(this.uppanel);
            this.panel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(980, 580);
            this.panel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.inventorylistBox);
            this.panel1.Controls.Add(this.inventorylabel);
            this.panel1.Location = new System.Drawing.Point(8, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 515);
            this.panel1.TabIndex = 6;
            // 
            // inventorylistBox
            // 
            this.inventorylistBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inventorylistBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventorylistBox.FormattingEnabled = true;
            this.inventorylistBox.ItemHeight = 41;
            this.inventorylistBox.Items.AddRange(new object[] {
            "a",
            "b",
            "c",
            "d",
            "e",
            "f",
            "g",
            "h",
            "i",
            "j",
            "k",
            "l",
            "m",
            "n",
            "o",
            "p",
            "r",
            "s",
            "t",
            "u",
            "w",
            "x",
            "y",
            "z"});
            this.inventorylistBox.Location = new System.Drawing.Point(13, 62);
            this.inventorylistBox.Name = "inventorylistBox";
            this.inventorylistBox.Size = new System.Drawing.Size(936, 414);
            this.inventorylistBox.TabIndex = 12;
            // 
            // inventorylabel
            // 
            this.inventorylabel.AutoSize = true;
            this.inventorylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inventorylabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inventorylabel.ForeColor = System.Drawing.Color.White;
            this.inventorylabel.Location = new System.Drawing.Point(13, 14);
            this.inventorylabel.Name = "inventorylabel";
            this.inventorylabel.Size = new System.Drawing.Size(212, 43);
            this.inventorylabel.TabIndex = 11;
            this.inventorylabel.Text = "Your Inventory";
            // 
            // labelpanel
            // 
            this.labelpanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelpanel.Controls.Add(this.close);
            this.labelpanel.Controls.Add(this.max);
            this.labelpanel.Controls.Add(this.min);
            this.labelpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelpanel.Location = new System.Drawing.Point(0, 3);
            this.labelpanel.Name = "labelpanel";
            this.labelpanel.Size = new System.Drawing.Size(980, 47);
            this.labelpanel.TabIndex = 5;
            this.labelpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseDown);
            this.labelpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseMove);
            this.labelpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseUp);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BZBackColor = System.Drawing.SystemColors.GrayText;
            this.close.DisplayText = "X";
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(935, -1);
            this.close.MouseClickColor1 = System.Drawing.Color.Tomato;
            this.close.MouseHoverColor = System.Drawing.Color.Salmon;
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 50);
            this.close.TabIndex = 7;
            this.close.Text = "X";
            this.close.TextLocation_X = 10;
            this.close.TextLocation_Y = 12;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // max
            // 
            this.max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.max.BackColor = System.Drawing.SystemColors.GrayText;
            this.max.BZBackColor = System.Drawing.SystemColors.GrayText;
            this.max.CFormState = customforms.MinMaxButton.CustomFormState.Normal;
            this.max.DisplayText = "_";
            this.max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.max.ForeColor = System.Drawing.Color.White;
            this.max.Location = new System.Drawing.Point(894, -2);
            this.max.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.max.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(40, 50);
            this.max.TabIndex = 6;
            this.max.Text = "minMaxButton1";
            this.max.TextLocation_X = 13;
            this.max.TextLocation_Y = 21;
            this.max.UseVisualStyleBackColor = false;
            this.max.Click += new System.EventHandler(this.max_Click);
            // 
            // min
            // 
            this.min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.min.BZBackColor = System.Drawing.SystemColors.GrayText;
            this.min.DisplayText = "_";
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.min.ForeColor = System.Drawing.Color.White;
            this.min.Location = new System.Drawing.Point(853, -1);
            this.min.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.min.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(40, 50);
            this.min.TabIndex = 4;
            this.min.Text = "_";
            this.min.TextLocation_X = 6;
            this.min.TextLocation_Y = -16;
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // inventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(980, 583);
            this.ControlBox = false;
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.downpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inventoryForm";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.labelpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel downpanel;
        private Panel rightpanel;
        private Panel leftpanel;
        private ToolTip toolTip1;
        private Panel uppanel;
        private ButtonZ min;
        private MinMaxButton max;
        private ButtonZ close;
        private Panel labelpanel;
        protected Panel panel;
        private Panel panel1;
        private Label inventorylabel;
        private ListBox inventorylistBox;
    }
}