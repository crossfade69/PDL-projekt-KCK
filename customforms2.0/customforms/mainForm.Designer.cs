namespace customforms
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.downpanel = new System.Windows.Forms.Panel();
            this.rightpanel = new System.Windows.Forms.Panel();
            this.leftpanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uppanel = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.shop = new customforms.Shop();
            this.profile = new customforms.Profile();
            this.friends = new customforms.Friends();
            this.games = new customforms.Games();
            this.sidemenupanel = new System.Windows.Forms.FlowLayoutPanel();
            this.logopanel = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.Label();
            this.profilepanel = new System.Windows.Forms.Panel();
            this.profilebutton = new System.Windows.Forms.Button();
            this.gamesbutton = new System.Windows.Forms.Button();
            this.shoppanel = new System.Windows.Forms.Panel();
            this.shopbutton = new System.Windows.Forms.Button();
            this.friendsbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.twitbutton = new System.Windows.Forms.Button();
            this.fbbutton = new System.Windows.Forms.Button();
            this.helpbutton = new System.Windows.Forms.Button();
            this.condbutton = new System.Windows.Forms.Button();
            this.labelpanel = new System.Windows.Forms.Panel();
            this.close = new customforms.ButtonZ();
            this.max = new customforms.MinMaxButton();
            this.min = new customforms.ButtonZ();
            this.settingbutton = new System.Windows.Forms.Button();
            this.profilecircle = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.sidemenupanel.SuspendLayout();
            this.logopanel.SuspendLayout();
            this.profilepanel.SuspendLayout();
            this.shoppanel.SuspendLayout();
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
            this.downpanel.Size = new System.Drawing.Size(1492, 3);
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
            this.rightpanel.Location = new System.Drawing.Point(1490, 0);
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
            this.uppanel.Size = new System.Drawing.Size(1492, 3);
            this.uppanel.TabIndex = 1;
            this.uppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.uppanel_MouseDown);
            this.uppanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.uppanel_MouseMove);
            this.uppanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.uppanel_MouseUp);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.MediumPurple;
            this.panel.Controls.Add(this.shop);
            this.panel.Controls.Add(this.profile);
            this.panel.Controls.Add(this.friends);
            this.panel.Controls.Add(this.games);
            this.panel.Controls.Add(this.sidemenupanel);
            this.panel.Controls.Add(this.labelpanel);
            this.panel.Controls.Add(this.uppanel);
            this.panel.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1492, 580);
            this.panel.TabIndex = 1;
            // 
            // shop
            // 
            this.shop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shop.Location = new System.Drawing.Point(183, 52);
            this.shop.Name = "shop";
            this.shop.Size = new System.Drawing.Size(1304, 528);
            this.shop.TabIndex = 10;
            // 
            // profile
            // 
            this.profile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profile.Location = new System.Drawing.Point(183, 52);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(1309, 528);
            this.profile.TabIndex = 9;
            // 
            // friends
            // 
            this.friends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friends.Location = new System.Drawing.Point(184, 52);
            this.friends.Name = "friends";
            this.friends.Size = new System.Drawing.Size(1639, 666);
            this.friends.TabIndex = 8;
            // 
            // games
            // 
            this.games.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.games.Location = new System.Drawing.Point(184, 53);
            this.games.Name = "games";
            this.games.Size = new System.Drawing.Size(1639, 666);
            this.games.TabIndex = 7;
            // 
            // sidemenupanel
            // 
            this.sidemenupanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidemenupanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sidemenupanel.Controls.Add(this.logopanel);
            this.sidemenupanel.Controls.Add(this.profilepanel);
            this.sidemenupanel.Controls.Add(this.gamesbutton);
            this.sidemenupanel.Controls.Add(this.shoppanel);
            this.sidemenupanel.Controls.Add(this.friendsbutton);
            this.sidemenupanel.Controls.Add(this.panel1);
            this.sidemenupanel.Controls.Add(this.helpbutton);
            this.sidemenupanel.Controls.Add(this.condbutton);
            this.sidemenupanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidemenupanel.Location = new System.Drawing.Point(2, 3);
            this.sidemenupanel.Name = "sidemenupanel";
            this.sidemenupanel.Size = new System.Drawing.Size(179, 577);
            this.sidemenupanel.TabIndex = 6;
            // 
            // logopanel
            // 
            this.logopanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.logopanel.Controls.Add(this.logo);
            this.logopanel.Location = new System.Drawing.Point(3, 3);
            this.logopanel.Name = "logopanel";
            this.logopanel.Size = new System.Drawing.Size(221, 75);
            this.logopanel.TabIndex = 7;
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logo.Location = new System.Drawing.Point(50, 15);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(75, 40);
            this.logo.TabIndex = 9;
            this.logo.Text = "logo";
            this.logo.Click += new System.EventHandler(this.label1_Click);
            // 
            // profilepanel
            // 
            this.profilepanel.Controls.Add(this.profilebutton);
            this.profilepanel.Location = new System.Drawing.Point(3, 84);
            this.profilepanel.Name = "profilepanel";
            this.profilepanel.Size = new System.Drawing.Size(221, 45);
            this.profilepanel.TabIndex = 8;
            // 
            // profilebutton
            // 
            this.profilebutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.profilebutton.FlatAppearance.BorderSize = 0;
            this.profilebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilebutton.ForeColor = System.Drawing.Color.White;
            this.profilebutton.Image = ((System.Drawing.Image)(resources.GetObject("profilebutton.Image")));
            this.profilebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.profilebutton.Location = new System.Drawing.Point(-3, 0);
            this.profilebutton.Name = "profilebutton";
            this.profilebutton.Size = new System.Drawing.Size(179, 45);
            this.profilebutton.TabIndex = 7;
            this.profilebutton.Text = "Profile";
            this.profilebutton.UseVisualStyleBackColor = false;
            this.profilebutton.Click += new System.EventHandler(this.profilebutton_Click);
            // 
            // gamesbutton
            // 
            this.gamesbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gamesbutton.FlatAppearance.BorderSize = 0;
            this.gamesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamesbutton.ForeColor = System.Drawing.Color.White;
            this.gamesbutton.Image = ((System.Drawing.Image)(resources.GetObject("gamesbutton.Image")));
            this.gamesbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gamesbutton.Location = new System.Drawing.Point(3, 135);
            this.gamesbutton.Name = "gamesbutton";
            this.gamesbutton.Size = new System.Drawing.Size(176, 45);
            this.gamesbutton.TabIndex = 7;
            this.gamesbutton.Text = "Games";
            this.gamesbutton.UseVisualStyleBackColor = false;
            this.gamesbutton.Click += new System.EventHandler(this.gamesbutton_Click);
            // 
            // shoppanel
            // 
            this.shoppanel.Controls.Add(this.shopbutton);
            this.shoppanel.Location = new System.Drawing.Point(3, 186);
            this.shoppanel.Name = "shoppanel";
            this.shoppanel.Size = new System.Drawing.Size(221, 45);
            this.shoppanel.TabIndex = 9;
            // 
            // shopbutton
            // 
            this.shopbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.shopbutton.FlatAppearance.BorderSize = 0;
            this.shopbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopbutton.ForeColor = System.Drawing.Color.White;
            this.shopbutton.Image = ((System.Drawing.Image)(resources.GetObject("shopbutton.Image")));
            this.shopbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shopbutton.Location = new System.Drawing.Point(0, 0);
            this.shopbutton.Name = "shopbutton";
            this.shopbutton.Size = new System.Drawing.Size(176, 45);
            this.shopbutton.TabIndex = 7;
            this.shopbutton.Text = "Shop";
            this.shopbutton.UseVisualStyleBackColor = false;
            this.shopbutton.Click += new System.EventHandler(this.shopbutton_Click);
            // 
            // friendsbutton
            // 
            this.friendsbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.friendsbutton.FlatAppearance.BorderSize = 0;
            this.friendsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendsbutton.ForeColor = System.Drawing.Color.White;
            this.friendsbutton.Image = ((System.Drawing.Image)(resources.GetObject("friendsbutton.Image")));
            this.friendsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.friendsbutton.Location = new System.Drawing.Point(3, 237);
            this.friendsbutton.Name = "friendsbutton";
            this.friendsbutton.Size = new System.Drawing.Size(176, 45);
            this.friendsbutton.TabIndex = 8;
            this.friendsbutton.Text = "Friends";
            this.friendsbutton.UseVisualStyleBackColor = false;
            this.friendsbutton.Click += new System.EventHandler(this.friendsbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.twitbutton);
            this.panel1.Controls.Add(this.fbbutton);
            this.panel1.Location = new System.Drawing.Point(3, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 37);
            this.panel1.TabIndex = 15;
            // 
            // twitbutton
            // 
            this.twitbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.twitbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.twitbutton.FlatAppearance.BorderSize = 0;
            this.twitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twitbutton.Image = ((System.Drawing.Image)(resources.GetObject("twitbutton.Image")));
            this.twitbutton.Location = new System.Drawing.Point(29, 0);
            this.twitbutton.Name = "twitbutton";
            this.twitbutton.Size = new System.Drawing.Size(37, 37);
            this.twitbutton.TabIndex = 1;
            this.twitbutton.UseVisualStyleBackColor = false;
            this.twitbutton.Click += new System.EventHandler(this.twitbutton_Click);
            // 
            // fbbutton
            // 
            this.fbbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fbbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fbbutton.FlatAppearance.BorderSize = 0;
            this.fbbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fbbutton.Image = ((System.Drawing.Image)(resources.GetObject("fbbutton.Image")));
            this.fbbutton.Location = new System.Drawing.Point(-5, 0);
            this.fbbutton.Name = "fbbutton";
            this.fbbutton.Size = new System.Drawing.Size(37, 37);
            this.fbbutton.TabIndex = 0;
            this.fbbutton.UseVisualStyleBackColor = false;
            this.fbbutton.Click += new System.EventHandler(this.fbbutton_Click);
            // 
            // helpbutton
            // 
            this.helpbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.helpbutton.FlatAppearance.BorderSize = 0;
            this.helpbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpbutton.ForeColor = System.Drawing.Color.White;
            this.helpbutton.Image = ((System.Drawing.Image)(resources.GetObject("helpbutton.Image")));
            this.helpbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helpbutton.Location = new System.Drawing.Point(3, 331);
            this.helpbutton.Name = "helpbutton";
            this.helpbutton.Size = new System.Drawing.Size(176, 45);
            this.helpbutton.TabIndex = 13;
            this.helpbutton.Text = "Help";
            this.helpbutton.UseVisualStyleBackColor = false;
            this.helpbutton.Click += new System.EventHandler(this.helpbutton_Click);
            // 
            // condbutton
            // 
            this.condbutton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.condbutton.FlatAppearance.BorderSize = 0;
            this.condbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.condbutton.ForeColor = System.Drawing.Color.White;
            this.condbutton.Image = ((System.Drawing.Image)(resources.GetObject("condbutton.Image")));
            this.condbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.condbutton.Location = new System.Drawing.Point(3, 382);
            this.condbutton.Name = "condbutton";
            this.condbutton.Size = new System.Drawing.Size(176, 45);
            this.condbutton.TabIndex = 14;
            this.condbutton.Text = "Conditions";
            this.condbutton.UseVisualStyleBackColor = false;
            this.condbutton.Click += new System.EventHandler(this.condbutton_Click);
            // 
            // labelpanel
            // 
            this.labelpanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.labelpanel.Controls.Add(this.close);
            this.labelpanel.Controls.Add(this.max);
            this.labelpanel.Controls.Add(this.min);
            this.labelpanel.Controls.Add(this.settingbutton);
            this.labelpanel.Controls.Add(this.profilecircle);
            this.labelpanel.Controls.Add(this.searchBox);
            this.labelpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelpanel.Location = new System.Drawing.Point(0, 3);
            this.labelpanel.Name = "labelpanel";
            this.labelpanel.Size = new System.Drawing.Size(1492, 47);
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
            this.close.Location = new System.Drawing.Point(1447, -1);
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
            this.max.Location = new System.Drawing.Point(1406, -2);
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
            this.min.Location = new System.Drawing.Point(1365, -1);
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
            // settingbutton
            // 
            this.settingbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingbutton.BackColor = System.Drawing.SystemColors.GrayText;
            this.settingbutton.FlatAppearance.BorderSize = 0;
            this.settingbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingbutton.Image = ((System.Drawing.Image)(resources.GetObject("settingbutton.Image")));
            this.settingbutton.Location = new System.Drawing.Point(1278, -3);
            this.settingbutton.Name = "settingbutton";
            this.settingbutton.Size = new System.Drawing.Size(26, 50);
            this.settingbutton.TabIndex = 3;
            this.settingbutton.UseVisualStyleBackColor = false;
            this.settingbutton.Click += new System.EventHandler(this.settingbutton_Click);
            // 
            // profilecircle
            // 
            this.profilecircle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profilecircle.BackColor = System.Drawing.SystemColors.GrayText;
            this.profilecircle.FlatAppearance.BorderSize = 0;
            this.profilecircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profilecircle.Image = ((System.Drawing.Image)(resources.GetObject("profilecircle.Image")));
            this.profilecircle.Location = new System.Drawing.Point(1309, -3);
            this.profilecircle.Name = "profilecircle";
            this.profilecircle.Size = new System.Drawing.Size(42, 49);
            this.profilecircle.TabIndex = 3;
            this.profilecircle.UseVisualStyleBackColor = false;
            this.profilecircle.Click += new System.EventHandler(this.profilecircle_Click);
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.Gray;
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Location = new System.Drawing.Point(199, 13);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.PlaceholderText = "Search";
            this.searchBox.Size = new System.Drawing.Size(239, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.Tag = "Search";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1492, 583);
            this.ControlBox = false;
            this.Controls.Add(this.leftpanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.downpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.sidemenupanel.ResumeLayout(false);
            this.logopanel.ResumeLayout(false);
            this.logopanel.PerformLayout();
            this.profilepanel.ResumeLayout(false);
            this.shoppanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private FlowLayoutPanel sidemenupanel;
        private Panel profilepanel;
        private Button profilebutton;
        private Panel logopanel;
        private Label logo;
        private Panel shoppanel;
        private Button shopbutton;
        private Button gamesbutton;
        private TextBox searchBox;
        private Button helpbutton;
        private Button condbutton;
        private Panel panel1;
        private Button twitbutton;
        private Button fbbutton;
        private Button settingbutton;
        private Button profilecircle;
        private Button friendsbutton;
        private Games games;
        private Profile profile;
        private Friends friends;
        private Shop shop;
    }
}