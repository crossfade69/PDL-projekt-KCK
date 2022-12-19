namespace customforms
{
    partial class editprofileForm
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
            this.citytextBox = new System.Windows.Forms.TextBox();
            this.countrytextBox = new System.Windows.Forms.TextBox();
            this.citylabel = new System.Windows.Forms.Label();
            this.profphotolabel = new System.Windows.Forms.Label();
            this.countrylabel = new System.Windows.Forms.Label();
            this.realnamelabel = new System.Windows.Forms.Label();
            this.profnamelabel = new System.Windows.Forms.Label();
            this.chooseFilebutton = new System.Windows.Forms.Button();
            this.realnametextBox = new System.Windows.Forms.TextBox();
            this.profiletextBox = new System.Windows.Forms.TextBox();
            this.saveeditbutton = new System.Windows.Forms.Button();
            this.labelpanel = new System.Windows.Forms.Panel();
            this.editscreenlabel = new System.Windows.Forms.Label();
            this.close = new customforms.ButtonZ();
            this.max = new customforms.MinMaxButton();
            this.min = new customforms.ButtonZ();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.profinfotextBox = new System.Windows.Forms.TextBox();
            this.profinfolabel = new System.Windows.Forms.Label();
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
            this.downpanel.Location = new System.Drawing.Point(0, 444);
            this.downpanel.Name = "downpanel";
            this.downpanel.Size = new System.Drawing.Size(655, 3);
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
            this.rightpanel.Location = new System.Drawing.Point(653, 0);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(2, 444);
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
            this.leftpanel.Size = new System.Drawing.Size(2, 444);
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
            this.uppanel.Size = new System.Drawing.Size(655, 3);
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
            this.panel.Size = new System.Drawing.Size(655, 444);
            this.panel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.profinfolabel);
            this.panel1.Controls.Add(this.profinfotextBox);
            this.panel1.Controls.Add(this.citytextBox);
            this.panel1.Controls.Add(this.countrytextBox);
            this.panel1.Controls.Add(this.citylabel);
            this.panel1.Controls.Add(this.profphotolabel);
            this.panel1.Controls.Add(this.countrylabel);
            this.panel1.Controls.Add(this.realnamelabel);
            this.panel1.Controls.Add(this.profnamelabel);
            this.panel1.Controls.Add(this.chooseFilebutton);
            this.panel1.Controls.Add(this.realnametextBox);
            this.panel1.Controls.Add(this.profiletextBox);
            this.panel1.Controls.Add(this.saveeditbutton);
            this.panel1.Location = new System.Drawing.Point(8, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 379);
            this.panel1.TabIndex = 6;
            // 
            // citytextBox
            // 
            this.citytextBox.Location = new System.Drawing.Point(278, 128);
            this.citytextBox.Name = "citytextBox";
            this.citytextBox.Size = new System.Drawing.Size(332, 27);
            this.citytextBox.TabIndex = 30;
            // 
            // countrytextBox
            // 
            this.countrytextBox.Location = new System.Drawing.Point(278, 95);
            this.countrytextBox.Name = "countrytextBox";
            this.countrytextBox.Size = new System.Drawing.Size(332, 27);
            this.countrytextBox.TabIndex = 29;
            // 
            // citylabel
            // 
            this.citylabel.AutoSize = true;
            this.citylabel.ForeColor = System.Drawing.Color.White;
            this.citylabel.Location = new System.Drawing.Point(238, 131);
            this.citylabel.Name = "citylabel";
            this.citylabel.Size = new System.Drawing.Size(34, 20);
            this.citylabel.TabIndex = 28;
            this.citylabel.Text = "City";
            // 
            // profphotolabel
            // 
            this.profphotolabel.AutoSize = true;
            this.profphotolabel.ForeColor = System.Drawing.Color.White;
            this.profphotolabel.Location = new System.Drawing.Point(179, 165);
            this.profphotolabel.Name = "profphotolabel";
            this.profphotolabel.Size = new System.Drawing.Size(95, 20);
            this.profphotolabel.TabIndex = 26;
            this.profphotolabel.Text = "Profile Photo";
            // 
            // countrylabel
            // 
            this.countrylabel.AutoSize = true;
            this.countrylabel.ForeColor = System.Drawing.Color.White;
            this.countrylabel.Location = new System.Drawing.Point(212, 98);
            this.countrylabel.Name = "countrylabel";
            this.countrylabel.Size = new System.Drawing.Size(60, 20);
            this.countrylabel.TabIndex = 25;
            this.countrylabel.Text = "Country";
            // 
            // realnamelabel
            // 
            this.realnamelabel.AutoSize = true;
            this.realnamelabel.ForeColor = System.Drawing.Color.White;
            this.realnamelabel.Location = new System.Drawing.Point(104, 65);
            this.realnamelabel.Name = "realnamelabel";
            this.realnamelabel.Size = new System.Drawing.Size(168, 20);
            this.realnamelabel.TabIndex = 24;
            this.realnamelabel.Text = "Real name and surname";
            // 
            // profnamelabel
            // 
            this.profnamelabel.AutoSize = true;
            this.profnamelabel.ForeColor = System.Drawing.Color.White;
            this.profnamelabel.Location = new System.Drawing.Point(179, 32);
            this.profnamelabel.Name = "profnamelabel";
            this.profnamelabel.Size = new System.Drawing.Size(93, 20);
            this.profnamelabel.TabIndex = 23;
            this.profnamelabel.Text = "Profile name";
            // 
            // chooseFilebutton
            // 
            this.chooseFilebutton.Location = new System.Drawing.Point(278, 161);
            this.chooseFilebutton.Name = "chooseFilebutton";
            this.chooseFilebutton.Size = new System.Drawing.Size(332, 29);
            this.chooseFilebutton.TabIndex = 22;
            this.chooseFilebutton.Text = "Choose a File";
            this.chooseFilebutton.UseVisualStyleBackColor = true;
            this.chooseFilebutton.Click += new System.EventHandler(this.chooseFilebutton_Click);
            // 
            // realnametextBox
            // 
            this.realnametextBox.Location = new System.Drawing.Point(278, 62);
            this.realnametextBox.Name = "realnametextBox";
            this.realnametextBox.Size = new System.Drawing.Size(332, 27);
            this.realnametextBox.TabIndex = 20;
            // 
            // profiletextBox
            // 
            this.profiletextBox.Location = new System.Drawing.Point(278, 29);
            this.profiletextBox.Name = "profiletextBox";
            this.profiletextBox.Size = new System.Drawing.Size(332, 27);
            this.profiletextBox.TabIndex = 19;
            // 
            // saveeditbutton
            // 
            this.saveeditbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveeditbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.saveeditbutton.FlatAppearance.BorderSize = 0;
            this.saveeditbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveeditbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveeditbutton.ForeColor = System.Drawing.Color.White;
            this.saveeditbutton.Location = new System.Drawing.Point(520, 324);
            this.saveeditbutton.Name = "saveeditbutton";
            this.saveeditbutton.Size = new System.Drawing.Size(99, 36);
            this.saveeditbutton.TabIndex = 18;
            this.saveeditbutton.Text = "Save";
            this.saveeditbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveeditbutton.UseVisualStyleBackColor = false;
            // 
            // labelpanel
            // 
            this.labelpanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelpanel.Controls.Add(this.editscreenlabel);
            this.labelpanel.Controls.Add(this.close);
            this.labelpanel.Controls.Add(this.max);
            this.labelpanel.Controls.Add(this.min);
            this.labelpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelpanel.Location = new System.Drawing.Point(0, 3);
            this.labelpanel.Name = "labelpanel";
            this.labelpanel.Size = new System.Drawing.Size(655, 47);
            this.labelpanel.TabIndex = 5;
            this.labelpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseDown);
            this.labelpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseMove);
            this.labelpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labelpanel_MouseUp);
            // 
            // editscreenlabel
            // 
            this.editscreenlabel.AutoSize = true;
            this.editscreenlabel.ForeColor = System.Drawing.Color.White;
            this.editscreenlabel.Location = new System.Drawing.Point(8, 13);
            this.editscreenlabel.Name = "editscreenlabel";
            this.editscreenlabel.Size = new System.Drawing.Size(82, 20);
            this.editscreenlabel.TabIndex = 24;
            this.editscreenlabel.Text = "Edit Profile";
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BZBackColor = System.Drawing.SystemColors.GrayText;
            this.close.DisplayText = "X";
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(610, -1);
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
            this.max.Location = new System.Drawing.Point(569, -2);
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
            this.min.Location = new System.Drawing.Point(528, -1);
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
            // profinfotextBox
            // 
            this.profinfotextBox.Location = new System.Drawing.Point(278, 196);
            this.profinfotextBox.Multiline = true;
            this.profinfotextBox.Name = "profinfotextBox";
            this.profinfotextBox.Size = new System.Drawing.Size(332, 100);
            this.profinfotextBox.TabIndex = 31;
            // 
            // profinfolabel
            // 
            this.profinfolabel.AutoSize = true;
            this.profinfolabel.ForeColor = System.Drawing.Color.White;
            this.profinfolabel.Location = new System.Drawing.Point(190, 196);
            this.profinfolabel.Name = "profinfolabel";
            this.profinfolabel.Size = new System.Drawing.Size(82, 20);
            this.profinfolabel.TabIndex = 32;
            this.profinfolabel.Text = "Profile Info";
            // 
            // editprofileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(655, 447);
            this.ControlBox = false;
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.downpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editprofileForm";
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
        private Button saveeditbutton;
        private Label profphotolabel;
        private Label countrylabel;
        private Label realnamelabel;
        private Label profnamelabel;
        private Button chooseFilebutton;
        private TextBox realnametextBox;
        private TextBox profiletextBox;
        private TextBox citytextBox;
        private TextBox countrytextBox;
        private Label citylabel;
        private Label editscreenlabel;
        private TextBox profinfotextBox;
        private Label profinfolabel;
    }
}