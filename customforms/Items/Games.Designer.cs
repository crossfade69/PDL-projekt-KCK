namespace customforms
{
    partial class Games
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.shownGamesListBox = new System.Windows.Forms.ListBox();
            this.gamesTitleTextBox = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.shownGamesListBox);
            this.panel2.Controls.Add(this.gamesTitleTextBox);
            this.panel2.Location = new System.Drawing.Point(17, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 375);
            this.panel2.TabIndex = 17;
            // 
            // shownGamesListBox
            // 
            this.shownGamesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shownGamesListBox.BackColor = System.Drawing.Color.Thistle;
            this.shownGamesListBox.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shownGamesListBox.FormattingEnabled = true;
            this.shownGamesListBox.ItemHeight = 36;
            this.shownGamesListBox.Location = new System.Drawing.Point(21, 50);
            this.shownGamesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shownGamesListBox.Name = "shownGamesListBox";
            this.shownGamesListBox.Size = new System.Drawing.Size(1162, 292);
            this.shownGamesListBox.Sorted = true;
            this.shownGamesListBox.TabIndex = 18;
            this.shownGamesListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // gamesTitleTextBox
            // 
            this.gamesTitleTextBox.AutoSize = true;
            this.gamesTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gamesTitleTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gamesTitleTextBox.ForeColor = System.Drawing.Color.White;
            this.gamesTitleTextBox.Location = new System.Drawing.Point(21, 16);
            this.gamesTitleTextBox.Name = "gamesTitleTextBox";
            this.gamesTitleTextBox.Size = new System.Drawing.Size(142, 34);
            this.gamesTitleTextBox.TabIndex = 17;
            this.gamesTitleTextBox.Text = "Your Games";
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
            this.panel1.Size = new System.Drawing.Size(1234, 400);
            this.panel1.TabIndex = 18;
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Games";
            this.Size = new System.Drawing.Size(1234, 400);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label gamesTitleTextBox;
        public ListBox shownGamesListBox;
    }
}
