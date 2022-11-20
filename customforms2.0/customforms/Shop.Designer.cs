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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.shopsearchBox = new System.Windows.Forms.TextBox();
            this.searchfilterbutton = new System.Windows.Forms.Button();
            this.shopsearchbutton2 = new System.Windows.Forms.Button();
            this.gameliblabel = new System.Windows.Forms.Label();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 494);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.shopsearchBox);
            this.panel2.Controls.Add(this.searchfilterbutton);
            this.panel2.Controls.Add(this.shopsearchbutton2);
            this.panel2.Controls.Add(this.gameliblabel);
            this.panel2.Location = new System.Drawing.Point(17, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1279, 460);
            this.panel2.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 45;
            this.listBox1.Location = new System.Drawing.Point(26, 66);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1219, 364);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 19;
            // 
            // shopsearchBox
            // 
            this.shopsearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shopsearchBox.BackColor = System.Drawing.Color.Gray;
            this.shopsearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shopsearchBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shopsearchBox.Location = new System.Drawing.Point(211, 23);
            this.shopsearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.shopsearchBox.Name = "shopsearchBox";
            this.shopsearchBox.PlaceholderText = "Search";
            this.shopsearchBox.Size = new System.Drawing.Size(824, 36);
            this.shopsearchBox.TabIndex = 18;
            this.shopsearchBox.Tag = "Search";
            this.shopsearchBox.TextChanged += new System.EventHandler(this.shopsearchBox_TextChanged);
            // 
            // searchfilterbutton
            // 
            this.searchfilterbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchfilterbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchfilterbutton.FlatAppearance.BorderSize = 0;
            this.searchfilterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchfilterbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchfilterbutton.ForeColor = System.Drawing.Color.White;
            this.searchfilterbutton.Location = new System.Drawing.Point(1146, 22);
            this.searchfilterbutton.Name = "searchfilterbutton";
            this.searchfilterbutton.Size = new System.Drawing.Size(99, 36);
            this.searchfilterbutton.TabIndex = 16;
            this.searchfilterbutton.Text = ". . .";
            this.searchfilterbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchfilterbutton.UseVisualStyleBackColor = false;
            // 
            // shopsearchbutton2
            // 
            this.shopsearchbutton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shopsearchbutton2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.shopsearchbutton2.FlatAppearance.BorderSize = 0;
            this.shopsearchbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shopsearchbutton2.Image = ((System.Drawing.Image)(resources.GetObject("shopsearchbutton2.Image")));
            this.shopsearchbutton2.Location = new System.Drawing.Point(1041, 22);
            this.shopsearchbutton2.Name = "shopsearchbutton2";
            this.shopsearchbutton2.Size = new System.Drawing.Size(99, 36);
            this.shopsearchbutton2.TabIndex = 15;
            this.shopsearchbutton2.UseVisualStyleBackColor = false;
            // 
            // gameliblabel
            // 
            this.gameliblabel.AutoSize = true;
            this.gameliblabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gameliblabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameliblabel.ForeColor = System.Drawing.Color.White;
            this.gameliblabel.Location = new System.Drawing.Point(26, 21);
            this.gameliblabel.Name = "gameliblabel";
            this.gameliblabel.Size = new System.Drawing.Size(179, 42);
            this.gameliblabel.TabIndex = 9;
            this.gameliblabel.Text = "Games Shop";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Shop";
            this.Size = new System.Drawing.Size(1311, 533);
            this.Load += new System.EventHandler(this.Shop_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label gameliblabel;
        private Button searchfilterbutton;
        private Button shopsearchbutton2;
        private TextBox shopsearchBox;
        private ListBox listBox1;
    }
}
