namespace customforms
{
    partial class loginForm
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
            this.passwordlabel = new System.Windows.Forms.Label();
            this.enterprofnamelabel = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.profiletextBox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.labelpanel = new System.Windows.Forms.Panel();
            this.loginscreenlabel = new System.Windows.Forms.Label();
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
            this.downpanel.Location = new System.Drawing.Point(0, 176);
            this.downpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.downpanel.Name = "downpanel";
            this.downpanel.Size = new System.Drawing.Size(424, 2);
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
            this.rightpanel.Location = new System.Drawing.Point(422, 0);
            this.rightpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(2, 176);
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
            this.leftpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(2, 176);
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
            this.uppanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uppanel.Name = "uppanel";
            this.uppanel.Size = new System.Drawing.Size(424, 2);
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
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(424, 176);
            this.panel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.passwordlabel);
            this.panel1.Controls.Add(this.enterprofnamelabel);
            this.panel1.Controls.Add(this.passwordtextBox);
            this.panel1.Controls.Add(this.profiletextBox);
            this.panel1.Controls.Add(this.loginbutton);
            this.panel1.Location = new System.Drawing.Point(7, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 128);
            this.panel1.TabIndex = 6;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.ForeColor = System.Drawing.Color.White;
            this.passwordlabel.Location = new System.Drawing.Point(36, 49);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(57, 15);
            this.passwordlabel.TabIndex = 24;
            this.passwordlabel.Text = "Password";
            // 
            // enterprofnamelabel
            // 
            this.enterprofnamelabel.AutoSize = true;
            this.enterprofnamelabel.ForeColor = System.Drawing.Color.White;
            this.enterprofnamelabel.Location = new System.Drawing.Point(13, 22);
            this.enterprofnamelabel.Name = "enterprofnamelabel";
            this.enterprofnamelabel.Size = new System.Drawing.Size(76, 15);
            this.enterprofnamelabel.TabIndex = 23;
            this.enterprofnamelabel.Text = "Profile Name";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(102, 46);
            this.passwordtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(291, 23);
            this.passwordtextBox.TabIndex = 1;
            // 
            // profiletextBox
            // 
            this.profiletextBox.Location = new System.Drawing.Point(102, 20);
            this.profiletextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profiletextBox.Name = "profiletextBox";
            this.profiletextBox.Size = new System.Drawing.Size(291, 23);
            this.profiletextBox.TabIndex = 0;
            // 
            // loginbutton
            // 
            this.loginbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loginbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(164, 80);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(87, 27);
            this.loginbutton.TabIndex = 2;
            this.loginbutton.Text = "Login";
            this.loginbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // labelpanel
            // 
            this.labelpanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelpanel.Controls.Add(this.loginscreenlabel);
            this.labelpanel.Controls.Add(this.close);
            this.labelpanel.Controls.Add(this.max);
            this.labelpanel.Controls.Add(this.min);
            this.labelpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelpanel.Location = new System.Drawing.Point(0, 2);
            this.labelpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelpanel.Name = "labelpanel";
            this.labelpanel.Size = new System.Drawing.Size(424, 35);
            this.labelpanel.TabIndex = 5;
            this.labelpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseDown);
            this.labelpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseMove);
            this.labelpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseUp);
            // 
            // loginscreenlabel
            // 
            this.loginscreenlabel.AutoSize = true;
            this.loginscreenlabel.ForeColor = System.Drawing.Color.White;
            this.loginscreenlabel.Location = new System.Drawing.Point(7, 10);
            this.loginscreenlabel.Name = "loginscreenlabel";
            this.loginscreenlabel.Size = new System.Drawing.Size(64, 15);
            this.loginscreenlabel.TabIndex = 24;
            this.loginscreenlabel.Text = "Logging In";
            this.loginscreenlabel.Click += new System.EventHandler(this.loginscreenlabel_Click);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BZBackColor = System.Drawing.SystemColors.GrayText;
            this.close.DisplayText = "X";
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(385, -1);
            this.close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close.MouseClickColor1 = System.Drawing.Color.Tomato;
            this.close.MouseHoverColor = System.Drawing.Color.Salmon;
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 38);
            this.close.TabIndex = 5;
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
            this.max.Location = new System.Drawing.Point(349, -2);
            this.max.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.max.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.max.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(35, 38);
            this.max.TabIndex = 4;
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
            this.min.Location = new System.Drawing.Point(313, -1);
            this.min.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.min.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.min.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(35, 38);
            this.min.TabIndex = 3;
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
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(424, 178);
            this.ControlBox = false;
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.downpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginForm_KeyDown);
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
        private Label loginscreenlabel;
        private Label passwordlabel;
        private Label enterprofnamelabel;
        private TextBox passwordtextBox;
        private TextBox profiletextBox;
    }
}