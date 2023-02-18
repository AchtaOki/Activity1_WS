namespace ClientSoap_DotNet2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMt = new System.Windows.Forms.TextBox();
            this.btnConversion = new System.Windows.Forms.Button();
            this.btnComptes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Montant";
            // 
            // textBoxMt
            // 
            this.textBoxMt.Location = new System.Drawing.Point(222, 51);
            this.textBoxMt.Name = "textBoxMt";
            this.textBoxMt.Size = new System.Drawing.Size(100, 23);
            this.textBoxMt.TabIndex = 1;
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(352, 51);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(75, 23);
            this.btnConversion.TabIndex = 2;
            this.btnConversion.Text = "Conversion";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // btnComptes
            // 
            this.btnComptes.Location = new System.Drawing.Point(433, 51);
            this.btnComptes.Name = "btnComptes";
            this.btnComptes.Size = new System.Drawing.Size(75, 23);
            this.btnComptes.TabIndex = 3;
            this.btnComptes.Text = "Comptes";
            this.btnComptes.UseVisualStyleBackColor = true;
            this.btnComptes.Click += new System.EventHandler(this.btnComptes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultat";
            // 
            // textBoxRes
            // 
            this.textBoxRes.Location = new System.Drawing.Point(222, 87);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.Size = new System.Drawing.Size(100, 23);
            this.textBoxRes.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(166, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComptes);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.textBoxMt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBoxMt;
        private Button btnConversion;
        private Button btnComptes;
        private Label label2;
        private TextBox textBoxRes;
        private DataGridView dataGridView1;
    }
}