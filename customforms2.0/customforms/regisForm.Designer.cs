namespace customforms
{
    partial class regisForm
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
            this.regisbutton = new System.Windows.Forms.Button();
            this.confpswdlabel = new System.Windows.Forms.Label();
            this.confpswdtextBox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.enterprofnamelabel = new System.Windows.Forms.Label();
            this.realnametextBox = new System.Windows.Forms.TextBox();
            this.profiletextBox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.labelpanel = new System.Windows.Forms.Panel();
            this.regisscreenlabel = new System.Windows.Forms.Label();
            this.close = new customforms.ButtonZ();
            this.max = new customforms.MinMaxButton();
            this.min = new customforms.ButtonZ();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.downpanel.Location = new System.Drawing.Point(0, 257);
            this.downpanel.Name = "downpanel";
            this.downpanel.Size = new System.Drawing.Size(509, 3);
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
            this.rightpanel.Location = new System.Drawing.Point(507, 0);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(2, 257);
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
            this.leftpanel.Size = new System.Drawing.Size(2, 257);
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
            this.uppanel.Size = new System.Drawing.Size(509, 3);
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
            this.panel.Size = new System.Drawing.Size(509, 257);
            this.panel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.regisbutton);
            this.panel1.Controls.Add(this.confpswdlabel);
            this.panel1.Controls.Add(this.confpswdtextBox);
            this.panel1.Controls.Add(this.passwordlabel);
            this.panel1.Controls.Add(this.enterprofnamelabel);
            this.panel1.Controls.Add(this.realnametextBox);
            this.panel1.Controls.Add(this.profiletextBox);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Location = new System.Drawing.Point(8, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 192);
            this.panel1.TabIndex = 6;
            // 
            // regisbutton
            // 
            this.regisbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.regisbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.regisbutton.FlatAppearance.BorderSize = 0;
            this.regisbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regisbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regisbutton.ForeColor = System.Drawing.Color.White;
            this.regisbutton.Location = new System.Drawing.Point(28, 136);
            this.regisbutton.Name = "regisbutton";
            this.regisbutton.Size = new System.Drawing.Size(99, 36);
            this.regisbutton.TabIndex = 27;
            this.regisbutton.Text = "Register";
            this.regisbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.regisbutton.UseVisualStyleBackColor = false;
            this.regisbutton.Click += new System.EventHandler(this.regisbutton_Click);
            // 
            // confpswdlabel
            // 
            this.confpswdlabel.AutoSize = true;
            this.confpswdlabel.ForeColor = System.Drawing.Color.White;
            this.confpswdlabel.Location = new System.Drawing.Point(14, 95);
            this.confpswdlabel.Name = "confpswdlabel";
            this.confpswdlabel.Size = new System.Drawing.Size(127, 20);
            this.confpswdlabel.TabIndex = 26;
            this.confpswdlabel.Text = "Confirm Password";
            // 
            // confpswdtextBox
            // 
            this.confpswdtextBox.Location = new System.Drawing.Point(144, 92);
            this.confpswdtextBox.Name = "confpswdtextBox";
            this.confpswdtextBox.Size = new System.Drawing.Size(332, 27);
            this.confpswdtextBox.TabIndex = 25;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.ForeColor = System.Drawing.Color.White;
            this.passwordlabel.Location = new System.Drawing.Point(71, 62);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(70, 20);
            this.passwordlabel.TabIndex = 24;
            this.passwordlabel.Text = "Password";
            // 
            // enterprofnamelabel
            // 
            this.enterprofnamelabel.AutoSize = true;
            this.enterprofnamelabel.ForeColor = System.Drawing.Color.White;
            this.enterprofnamelabel.Location = new System.Drawing.Point(45, 29);
            this.enterprofnamelabel.Name = "enterprofnamelabel";
            this.enterprofnamelabel.Size = new System.Drawing.Size(96, 20);
            this.enterprofnamelabel.TabIndex = 23;
            this.enterprofnamelabel.Text = "Profile Name";
            // 
            // realnametextBox
            // 
            this.realnametextBox.Location = new System.Drawing.Point(144, 59);
            this.realnametextBox.Name = "realnametextBox";
            this.realnametextBox.Size = new System.Drawing.Size(332, 27);
            this.realnametextBox.TabIndex = 20;
            // 
            // profiletextBox
            // 
            this.profiletextBox.Location = new System.Drawing.Point(144, 26);
            this.profiletextBox.Name = "profiletextBox";
            this.profiletextBox.Size = new System.Drawing.Size(332, 27);
            this.profiletextBox.TabIndex = 19;
            // 
            // loginbutton
            // 
            this.loginbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(156, 136);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(320, 36);
            this.loginbutton.TabIndex = 18;
            this.loginbutton.Text = "Already registered? Login Now";
            this.loginbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // labelpanel
            // 
            this.labelpanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelpanel.Controls.Add(this.regisscreenlabel);
            this.labelpanel.Controls.Add(this.close);
            this.labelpanel.Controls.Add(this.max);
            this.labelpanel.Controls.Add(this.min);
            this.labelpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelpanel.Location = new System.Drawing.Point(0, 3);
            this.labelpanel.Name = "labelpanel";
            this.labelpanel.Size = new System.Drawing.Size(509, 47);
            this.labelpanel.TabIndex = 5;
            this.labelpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseDown);
            this.labelpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseMove);
            this.labelpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseUp);
            // 
            // regisscreenlabel
            // 
            this.regisscreenlabel.AutoSize = true;
            this.regisscreenlabel.ForeColor = System.Drawing.Color.White;
            this.regisscreenlabel.Location = new System.Drawing.Point(8, 13);
            this.regisscreenlabel.Name = "regisscreenlabel";
            this.regisscreenlabel.Size = new System.Drawing.Size(89, 20);
            this.regisscreenlabel.TabIndex = 24;
            this.regisscreenlabel.Text = "Registration";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BZBackColor = System.Drawing.SystemColors.GrayText;
            this.close.DisplayText = "X";
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(464, -1);
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
            this.max.Location = new System.Drawing.Point(423, -2);
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
            this.min.Location = new System.Drawing.Point(382, -1);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // regisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(509, 260);
            this.ControlBox = false;
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.downpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "regisForm";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.labelpanel.ResumeLayout(false);
            this.labelpanel.PerformLayout();
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
        private OpenFileDialog openFileDialog1;
        private Button loginbutton;
        private Label regisscreenlabel;
        private Label passwordlabel;
        private Label enterprofnamelabel;
        private TextBox realnametextBox;
        private TextBox profiletextBox;
        private Label confpswdlabel;
        private TextBox confpswdtextBox;
        private Button regisbutton;
    }
}