namespace Cforms
{
    partial class Form1
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
            this.dodaj = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usuń = new System.Windows.Forms.Button();
            this.wyczyść = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(39, 685);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(167, 29);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(39, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(527, 524);
            this.listBox1.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(39, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(527, 29);
            this.progressBar1.TabIndex = 2;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 642);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(527, 27);
            this.textBox1.TabIndex = 3;
            // 
            // usuń
            // 
            this.usuń.Location = new System.Drawing.Point(212, 685);
            this.usuń.Name = "usuń";
            this.usuń.Size = new System.Drawing.Size(169, 29);
            this.usuń.TabIndex = 4;
            this.usuń.Text = "usuń";
            this.usuń.UseVisualStyleBackColor = true;
            this.usuń.Click += new System.EventHandler(this.usuń_Click);
            // 
            // wyczyść
            // 
            this.wyczyść.Location = new System.Drawing.Point(387, 685);
            this.wyczyść.Name = "wyczyść";
            this.wyczyść.Size = new System.Drawing.Size(179, 29);
            this.wyczyść.TabIndex = 5;
            this.wyczyść.Text = "wyczyść";
            this.wyczyść.UseVisualStyleBackColor = true;
            this.wyczyść.Click += new System.EventHandler(this.wyczyść_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 763);
            this.Controls.Add(this.wyczyść);
            this.Controls.Add(this.usuń);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dodaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button dodaj;
        private ListBox listBox1;
        private ProgressBar progressBar1;
        private TextBox textBox1;
        private Button usuń;
        private Button wyczyść;
    }
}