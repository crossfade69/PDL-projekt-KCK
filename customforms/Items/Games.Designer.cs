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
            panel2 = new Panel();
            button_directory = new Button();
            shownGamesListBox = new ListBox();
            gamesTitleTextBox = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.WindowFrame;
            panel2.Controls.Add(button_directory);
            panel2.Controls.Add(shownGamesListBox);
            panel2.Controls.Add(gamesTitleTextBox);
            panel2.Location = new Point(17, 13);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 375);
            panel2.TabIndex = 17;
            // 
            // button_directory
            // 
            button_directory.Location = new Point(169, 26);
            button_directory.Name = "button_directory";
            button_directory.Size = new Size(75, 23);
            button_directory.TabIndex = 19;
            button_directory.Text = "Select Directory";
            button_directory.UseVisualStyleBackColor = true;
            button_directory.Click += button1_Click;
            // 
            // shownGamesListBox
            // 
            shownGamesListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            shownGamesListBox.BackColor = Color.Thistle;
            shownGamesListBox.Font = new Font("Segoe UI", 19.8F, FontStyle.Regular, GraphicsUnit.Point);
            shownGamesListBox.FormattingEnabled = true;
            shownGamesListBox.ItemHeight = 36;
            shownGamesListBox.Location = new Point(21, 50);
            shownGamesListBox.Margin = new Padding(3, 2, 3, 2);
            shownGamesListBox.Name = "shownGamesListBox";
            shownGamesListBox.Size = new Size(1162, 292);
            shownGamesListBox.Sorted = true;
            shownGamesListBox.TabIndex = 18;
            shownGamesListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            shownGamesListBox.ControlAdded += shownGamesListBox_ControlAdded;
            shownGamesListBox.MouseDoubleClick += shownGamesListBox_MouseDoubleClick;
            // 
            // gamesTitleTextBox
            // 
            gamesTitleTextBox.AutoSize = true;
            gamesTitleTextBox.BorderStyle = BorderStyle.Fixed3D;
            gamesTitleTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            gamesTitleTextBox.ForeColor = Color.White;
            gamesTitleTextBox.Location = new Point(21, 16);
            gamesTitleTextBox.Name = "gamesTitleTextBox";
            gamesTitleTextBox.Size = new Size(142, 34);
            gamesTitleTextBox.TabIndex = 17;
            gamesTitleTextBox.Text = "Your Games";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.MediumPurple;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1234, 400);
            panel1.TabIndex = 18;
            // 
            // Games
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Games";
            Size = new Size(1234, 400);
            Load += games_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label gamesTitleTextBox;
        public ListBox shownGamesListBox;
        private Button button_directory;
    }
}
