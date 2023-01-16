namespace customforms
{
    partial class Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shopGamesListBox = new System.Windows.Forms.ListBox();
            this.shopSearchBox = new System.Windows.Forms.TextBox();
            this.searchFilterButton = new System.Windows.Forms.Button();
            this.shopSearchButton2 = new System.Windows.Forms.Button();
            this.gameLibLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1147, 370);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.shopGamesListBox);
            this.panel2.Controls.Add(this.shopSearchBox);
            this.panel2.Controls.Add(this.searchFilterButton);
            this.panel2.Controls.Add(this.shopSearchButton2);
            this.panel2.Controls.Add(this.gameLibLabel);
            this.panel2.Location = new System.Drawing.Point(15, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1119, 345);
            this.panel2.TabIndex = 17;
            // 
            // shopGamesListBox
            // 
            this.shopGamesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopGamesListBox.BackColor = System.Drawing.Color.Thistle;
            this.shopGamesListBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopGamesListBox.FormattingEnabled = true;
            this.shopGamesListBox.ItemHeight = 36;
            this.shopGamesListBox.Location = new System.Drawing.Point(23, 50);
            this.shopGamesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shopGamesListBox.Name = "shopGamesListBox";
            this.shopGamesListBox.Size = new System.Drawing.Size(1067, 256);
            this.shopGamesListBox.Sorted = true;
            this.shopGamesListBox.TabIndex = 19;
            this.shopGamesListBox.SelectedIndexChanged += new System.EventHandler(this.shopGamesListBox_SelectedIndexChanged);
            this.shopGamesListBox.SelectedValueChanged += new System.EventHandler(this.shopGamesListBox_SelectedValueChanged);
            this.shopGamesListBox.DoubleClick += new System.EventHandler(this.shopGamesListBox_DoubleClick);
            this.shopGamesListBox.Enter += new System.EventHandler(this.shopGamesListBox_Enter);
            // 
            // shopSearchBox
            // 
            this.shopSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopSearchBox.BackColor = System.Drawing.Color.Gray;
            this.shopSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shopSearchBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopSearchBox.Location = new System.Drawing.Point(185, 17);
            this.shopSearchBox.Name = "shopSearchBox";
            this.shopSearchBox.PlaceholderText = "Search";
            this.shopSearchBox.Size = new System.Drawing.Size(721, 29);
            this.shopSearchBox.TabIndex = 18;
            this.shopSearchBox.Tag = "Search";
            this.shopSearchBox.TextChanged += new System.EventHandler(this.shopsearchBox_TextChanged);
            // 
            // searchFilterButton
            // 
            this.searchFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchFilterButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchFilterButton.FlatAppearance.BorderSize = 0;
            this.searchFilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchFilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchFilterButton.ForeColor = System.Drawing.Color.White;
            this.searchFilterButton.Location = new System.Drawing.Point(1003, 16);
            this.searchFilterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchFilterButton.Name = "searchFilterButton";
            this.searchFilterButton.Size = new System.Drawing.Size(87, 27);
            this.searchFilterButton.TabIndex = 16;
            this.searchFilterButton.Text = ". . .";
            this.searchFilterButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchFilterButton.UseVisualStyleBackColor = false;
            // 
            // shopSearchButton2
            // 
            this.shopSearchButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shopSearchButton2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.shopSearchButton2.FlatAppearance.BorderSize = 0;
            this.shopSearchButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopSearchButton2.Image = ((System.Drawing.Image)(resources.GetObject("shopSearchButton2.Image")));
            this.shopSearchButton2.Location = new System.Drawing.Point(911, 16);
            this.shopSearchButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shopSearchButton2.Name = "shopSearchButton2";
            this.shopSearchButton2.Size = new System.Drawing.Size(87, 27);
            this.shopSearchButton2.TabIndex = 15;
            this.shopSearchButton2.UseVisualStyleBackColor = false;
            // 
            // gameLibLabel
            // 
            this.gameLibLabel.AutoSize = true;
            this.gameLibLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameLibLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameLibLabel.ForeColor = System.Drawing.Color.White;
            this.gameLibLabel.Location = new System.Drawing.Point(23, 16);
            this.gameLibLabel.Name = "gameLibLabel";
            this.gameLibLabel.Size = new System.Drawing.Size(144, 33);
            this.gameLibLabel.TabIndex = 9;
            this.gameLibLabel.Text = "Games Shop";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Shop";
            this.Size = new System.Drawing.Size(1147, 400);
            this.Load += new System.EventHandler(this.Shop_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label gameLibLabel;
        private Button searchFilterButton;
        private Button shopSearchButton2;
        private TextBox shopSearchBox;
        private ListBox shopGamesListBox;
    }
}
