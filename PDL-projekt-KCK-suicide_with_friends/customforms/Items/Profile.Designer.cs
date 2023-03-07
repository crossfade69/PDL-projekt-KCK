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
            this.additionalInfoText = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.editprofbutton = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.profpicbig = new System.Windows.Forms.PictureBox();
            this.profileNameText = new System.Windows.Forms.Label();
            this.friendsList = new System.Windows.Forms.ListBox();
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
            this.panel2.Controls.Add(this.additionalInfoText);
            this.panel2.Controls.Add(this.info);
            this.panel2.Controls.Add(this.editprofbutton);
            this.panel2.Controls.Add(this.infoPanel);
            this.panel2.Controls.Add(this.profpicbig);
            this.panel2.Controls.Add(this.profileNameText);
            this.panel2.Controls.Add(this.friendsList);
            this.panel2.Controls.Add(this.friendlistlabel);
            this.panel2.Location = new System.Drawing.Point(17, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 375);
            this.panel2.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(18, 158);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(760, 199);
            this.listBox1.TabIndex = 15;
            // 
            // activitylabel
            // 
            this.activitylabel.AutoSize = true;
            this.activitylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.activitylabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.activitylabel.ForeColor = System.Drawing.Color.White;
            this.activitylabel.Location = new System.Drawing.Point(18, 113);
            this.activitylabel.Name = "activitylabel";
            this.activitylabel.Size = new System.Drawing.Size(173, 34);
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
            this.inventoryprofbutton.Location = new System.Drawing.Point(793, 195);
            this.inventoryprofbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inventoryprofbutton.Name = "inventoryprofbutton";
            this.inventoryprofbutton.Size = new System.Drawing.Size(298, 34);
            this.inventoryprofbutton.TabIndex = 14;
            this.inventoryprofbutton.Text = "Inventory";
            this.inventoryprofbutton.UseVisualStyleBackColor = false;
            this.inventoryprofbutton.Click += new System.EventHandler(this.inventoryprofbutton_Click);
            // 
            // additionalInfoText
            // 
            this.additionalInfoText.AutoSize = true;
            this.additionalInfoText.ForeColor = System.Drawing.Color.White;
            this.additionalInfoText.Location = new System.Drawing.Point(108, 40);
            this.additionalInfoText.Name = "additionalInfoText";
            this.additionalInfoText.Size = new System.Drawing.Size(158, 15);
            this.additionalInfoText.TabIndex = 7;
            this.additionalInfoText.Text = "name surname, city, country";
            // 
            // info
            // 
            this.info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.info.AutoSize = true;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(345, 12);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(30, 17);
            this.info.TabIndex = 11;
            this.info.Text = "info";
            // 
            // editprofbutton
            // 
            this.editprofbutton.Location = new System.Drawing.Point(108, 60);
            this.editprofbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editprofbutton.Name = "editprofbutton";
            this.editprofbutton.Size = new System.Drawing.Size(168, 24);
            this.editprofbutton.TabIndex = 6;
            this.editprofbutton.Text = "Edit Profile";
            this.editprofbutton.UseVisualStyleBackColor = true;
            this.editprofbutton.Click += new System.EventHandler(this.editprofbutton_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.infoPanel.ForeColor = System.Drawing.Color.White;
            this.infoPanel.Location = new System.Drawing.Point(345, 31);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(433, 115);
            this.infoPanel.TabIndex = 12;
            // 
            // profpicbig
            // 
            this.profpicbig.Image = ((System.Drawing.Image)(resources.GetObject("profpicbig.Image")));
            this.profpicbig.Location = new System.Drawing.Point(18, 12);
            this.profpicbig.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profpicbig.Name = "profpicbig";
            this.profpicbig.Size = new System.Drawing.Size(84, 72);
            this.profpicbig.TabIndex = 5;
            this.profpicbig.TabStop = false;
            // 
            // profileNameText
            // 
            this.profileNameText.AutoSize = true;
            this.profileNameText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.profileNameText.ForeColor = System.Drawing.Color.White;
            this.profileNameText.Location = new System.Drawing.Point(107, 12);
            this.profileNameText.Name = "profileNameText";
            this.profileNameText.Size = new System.Drawing.Size(130, 30);
            this.profileNameText.TabIndex = 4;
            this.profileNameText.Text = "profilename";
            this.profileNameText.Click += new System.EventHandler(this.profilename_Click);
            // 
            // friendsList
            // 
            this.friendsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.friendsList.BackColor = System.Drawing.SystemColors.GrayText;
            this.friendsList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.friendsList.ForeColor = System.Drawing.Color.White;
            this.friendsList.FormattingEnabled = true;
            this.friendsList.ItemHeight = 15;
            this.friendsList.Location = new System.Drawing.Point(793, 31);
            this.friendsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friendsList.Name = "friendsList";
            this.friendsList.Size = new System.Drawing.Size(299, 154);
            this.friendsList.TabIndex = 10;
            // 
            // friendlistlabel
            // 
            this.friendlistlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.friendlistlabel.AutoSize = true;
            this.friendlistlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.friendlistlabel.ForeColor = System.Drawing.Color.White;
            this.friendlistlabel.Location = new System.Drawing.Point(793, 12);
            this.friendlistlabel.Name = "friendlistlabel";
            this.friendlistlabel.Size = new System.Drawing.Size(45, 17);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 400);
            this.panel1.TabIndex = 18;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(1148, 400);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profpicbig)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private ListBox friendsList;
        private Label friendlistlabel;
        private Label info;
        private Panel infoPanel;
        private Label additionalInfoText;
        private Button editprofbutton;
        private PictureBox profpicbig;
        private Label profileNameText;
        private Button inventoryprofbutton;
        private Label activitylabel;
        private ListBox listBox1;
    }
}
