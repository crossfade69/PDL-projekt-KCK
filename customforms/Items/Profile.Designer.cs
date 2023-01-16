namespace customforms
{
    partial class Profile
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.activitylabel = new System.Windows.Forms.Label();
            this.inventoryprofbutton = new System.Windows.Forms.Button();
            this.namesurname = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.editprofbutton = new System.Windows.Forms.Button();
            this.infopanel = new System.Windows.Forms.Panel();
            this.profpicbig = new System.Windows.Forms.PictureBox();
            this.profilename = new System.Windows.Forms.Label();
            this.friendlist = new System.Windows.Forms.ListBox();
            this.friendlistlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profpicbig)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.activitylabel);
            this.panel2.Controls.Add(this.inventoryprofbutton);
            this.panel2.Controls.Add(this.namesurname);
            this.panel2.Controls.Add(this.info);
            this.panel2.Controls.Add(this.editprofbutton);
            this.panel2.Controls.Add(this.infopanel);
            this.panel2.Controls.Add(this.profpicbig);
            this.panel2.Controls.Add(this.profilename);
            this.panel2.Controls.Add(this.friendlist);
            this.panel2.Controls.Add(this.friendlistlabel);
            this.panel2.Location = new System.Drawing.Point(19, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1273, 500);
            this.panel2.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(21, 211);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(868, 264);
            this.listBox1.TabIndex = 15;
            // 
            // activitylabel
            // 
            this.activitylabel.AutoSize = true;
            this.activitylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activitylabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activitylabel.ForeColor = System.Drawing.Color.White;
            this.activitylabel.Location = new System.Drawing.Point(21, 151);
            this.activitylabel.Name = "activitylabel";
            this.activitylabel.Size = new System.Drawing.Size(214, 43);
            this.activitylabel.TabIndex = 10;
            this.activitylabel.Text = "Recent Activity";
            // 
            // inventoryprofbutton
            // 
            this.inventoryprofbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inventoryprofbutton.BackColor = System.Drawing.SystemColors.GrayText;
            this.inventoryprofbutton.FlatAppearance.BorderSize = 0;
            this.inventoryprofbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryprofbutton.ForeColor = System.Drawing.Color.White;
            this.inventoryprofbutton.Image = ((System.Drawing.Image)(resources.GetObject("inventoryprofbutton.Image")));
            this.inventoryprofbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inventoryprofbutton.Location = new System.Drawing.Point(906, 260);
            this.inventoryprofbutton.Name = "inventoryprofbutton";
            this.inventoryprofbutton.Size = new System.Drawing.Size(341, 45);
            this.inventoryprofbutton.TabIndex = 14;
            this.inventoryprofbutton.Text = "Inventory";
            this.inventoryprofbutton.UseVisualStyleBackColor = false;
            this.inventoryprofbutton.Click += new System.EventHandler(this.inventoryprofbutton_Click);
            // 
            // namesurname
            // 
            this.namesurname.AutoSize = true;
            this.namesurname.ForeColor = System.Drawing.Color.White;
            this.namesurname.Location = new System.Drawing.Point(124, 53);
            this.namesurname.Name = "namesurname";
            this.namesurname.Size = new System.Drawing.Size(192, 20);
            this.namesurname.TabIndex = 7;
            this.namesurname.Text = "name surname, city, country";
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info.AutoSize = true;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(394, 16);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(37, 22);
            this.info.TabIndex = 11;
            this.info.Text = "info";
            // 
            // editprofbutton
            // 
            this.editprofbutton.Location = new System.Drawing.Point(124, 80);
            this.editprofbutton.Name = "editprofbutton";
            this.editprofbutton.Size = new System.Drawing.Size(192, 32);
            this.editprofbutton.TabIndex = 6;
            this.editprofbutton.Text = "Edit Profile";
            this.editprofbutton.UseVisualStyleBackColor = true;
            this.editprofbutton.Click += new System.EventHandler(this.editprofbutton_Click);
            // 
            // infopanel
            // 
            this.infopanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infopanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.infopanel.ForeColor = System.Drawing.Color.White;
            this.infopanel.Location = new System.Drawing.Point(394, 41);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(495, 153);
            this.infopanel.TabIndex = 12;
            // 
            // profpicbig
            // 
            this.profpicbig.Image = ((System.Drawing.Image)(resources.GetObject("profpicbig.Image")));
            this.profpicbig.Location = new System.Drawing.Point(21, 16);
            this.profpicbig.Name = "profpicbig";
            this.profpicbig.Size = new System.Drawing.Size(96, 96);
            this.profpicbig.TabIndex = 5;
            this.profpicbig.TabStop = false;
            // 
            // profilename
            // 
            this.profilename.AutoSize = true;
            this.profilename.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profilename.ForeColor = System.Drawing.Color.White;
            this.profilename.Location = new System.Drawing.Point(122, 16);
            this.profilename.Name = "profilename";
            this.profilename.Size = new System.Drawing.Size(166, 38);
            this.profilename.TabIndex = 4;
            this.profilename.Text = "profilename";
            // 
            // friendlist
            // 
            this.friendlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.friendlist.BackColor = System.Drawing.SystemColors.GrayText;
            this.friendlist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.friendlist.ForeColor = System.Drawing.Color.White;
            this.friendlist.FormattingEnabled = true;
            this.friendlist.ItemHeight = 20;
            this.friendlist.Location = new System.Drawing.Point(906, 41);
            this.friendlist.Name = "friendlist";
            this.friendlist.Size = new System.Drawing.Size(341, 204);
            this.friendlist.TabIndex = 10;
            // 
            // friendlistlabel
            // 
            this.friendlistlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.friendlistlabel.AutoSize = true;
            this.friendlistlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.friendlistlabel.ForeColor = System.Drawing.Color.White;
            this.friendlistlabel.Location = new System.Drawing.Point(906, 16);
            this.friendlistlabel.Name = "friendlistlabel";
            this.friendlistlabel.Size = new System.Drawing.Size(56, 22);
            this.friendlistlabel.TabIndex = 9;
            this.friendlistlabel.Text = "friends";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 533);
            this.panel1.TabIndex = 18;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1312, 533);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profpicbig)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private ListBox friendlist;
        private Label friendlistlabel;
        private Label info;
        private Panel infopanel;
        private Label namesurname;
        private Button editprofbutton;
        private PictureBox profpicbig;
        private Label profilename;
        private Button inventoryprofbutton;
        private Label activitylabel;
        private ListBox listBox1;
    }
}
