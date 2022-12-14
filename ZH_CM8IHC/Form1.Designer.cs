namespace ZH_CM8IHC
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttondel = new System.Windows.Forms.Button();
            this.textBoxszuro = new System.Windows.Forms.TextBox();
            this.listBoxdiak = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(435, 323);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttondel
            // 
            this.buttondel.Location = new System.Drawing.Point(500, 391);
            this.buttondel.Name = "buttondel";
            this.buttondel.Size = new System.Drawing.Size(120, 47);
            this.buttondel.TabIndex = 2;
            this.buttondel.Text = "Töröl";
            this.buttondel.UseVisualStyleBackColor = true;
            this.buttondel.Click += new System.EventHandler(this.buttondel_Click);
            // 
            // textBoxszuro
            // 
            this.textBoxszuro.Location = new System.Drawing.Point(35, 52);
            this.textBoxszuro.Name = "textBoxszuro";
            this.textBoxszuro.Size = new System.Drawing.Size(105, 23);
            this.textBoxszuro.TabIndex = 3;
            this.textBoxszuro.TextChanged += new System.EventHandler(this.textBoxszur_TextChanged);
            // 
            // listBoxdiak
            // 
            this.listBoxdiak.FormattingEnabled = true;
            this.listBoxdiak.ItemHeight = 15;
            this.listBoxdiak.Location = new System.Drawing.Point(35, 114);
            this.listBoxdiak.Name = "listBoxdiak";
            this.listBoxdiak.Size = new System.Drawing.Size(105, 154);
            this.listBoxdiak.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxdiak);
            this.Controls.Add(this.textBoxszuro);
            this.Controls.Add(this.buttondel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button buttondel;
        private TextBox textBoxszuro;
        private ListBox listBoxdiak;
    }
}