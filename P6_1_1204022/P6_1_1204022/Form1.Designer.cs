namespace P6_1_1204022
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbNAMA = new System.Windows.Forms.Label();
            this.lbSINGKATAN = new System.Windows.Forms.Label();
            this.lbKAPRODI = new System.Windows.Forms.Label();
            this.lbSEK = new System.Windows.Forms.Label();
            this.txtIdProdi = new System.Windows.Forms.TextBox();
            this.txtNamaProdi = new System.Windows.Forms.TextBox();
            this.txtSingkatan = new System.Windows.Forms.TextBox();
            this.txtKaProdi = new System.Windows.Forms.TextBox();
            this.txtSekProdi = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Input Prodi";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(24, 60);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(51, 13);
            this.lbID.TabIndex = 1;
            this.lbID.Text = "ID Prodi :";
            // 
            // lbNAMA
            // 
            this.lbNAMA.AutoSize = true;
            this.lbNAMA.Location = new System.Drawing.Point(24, 88);
            this.lbNAMA.Name = "lbNAMA";
            this.lbNAMA.Size = new System.Drawing.Size(68, 13);
            this.lbNAMA.TabIndex = 2;
            this.lbNAMA.Text = "Nama Prodi :";
            this.lbNAMA.Click += new System.EventHandler(this.txtNamaProdi_Click);
            // 
            // lbSINGKATAN
            // 
            this.lbSINGKATAN.AutoSize = true;
            this.lbSINGKATAN.Location = new System.Drawing.Point(24, 118);
            this.lbSINGKATAN.Name = "lbSINGKATAN";
            this.lbSINGKATAN.Size = new System.Drawing.Size(61, 13);
            this.lbSINGKATAN.TabIndex = 3;
            this.lbSINGKATAN.Text = "Singkatan :";
            // 
            // lbKAPRODI
            // 
            this.lbKAPRODI.AutoSize = true;
            this.lbKAPRODI.Location = new System.Drawing.Point(24, 149);
            this.lbKAPRODI.Name = "lbKAPRODI";
            this.lbKAPRODI.Size = new System.Drawing.Size(68, 13);
            this.lbKAPRODI.TabIndex = 4;
            this.lbKAPRODI.Text = "Ketua Prodi :";
            // 
            // lbSEK
            // 
            this.lbSEK.AutoSize = true;
            this.lbSEK.Location = new System.Drawing.Point(24, 178);
            this.lbSEK.Name = "lbSEK";
            this.lbSEK.Size = new System.Drawing.Size(87, 13);
            this.lbSEK.TabIndex = 5;
            this.lbSEK.Text = "Sekretaris Prodi :";
            // 
            // txtIdProdi
            // 
            this.txtIdProdi.Location = new System.Drawing.Point(121, 53);
            this.txtIdProdi.Name = "txtIdProdi";
            this.txtIdProdi.Size = new System.Drawing.Size(100, 20);
            this.txtIdProdi.TabIndex = 6;
            this.txtIdProdi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNamaProdi
            // 
            this.txtNamaProdi.Location = new System.Drawing.Point(121, 81);
            this.txtNamaProdi.Name = "txtNamaProdi";
            this.txtNamaProdi.Size = new System.Drawing.Size(100, 20);
            this.txtNamaProdi.TabIndex = 7;
            this.txtNamaProdi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSingkatan
            // 
            this.txtSingkatan.Location = new System.Drawing.Point(121, 111);
            this.txtSingkatan.Name = "txtSingkatan";
            this.txtSingkatan.Size = new System.Drawing.Size(100, 20);
            this.txtSingkatan.TabIndex = 8;
            // 
            // txtKaProdi
            // 
            this.txtKaProdi.Location = new System.Drawing.Point(121, 142);
            this.txtKaProdi.Name = "txtKaProdi";
            this.txtKaProdi.Size = new System.Drawing.Size(100, 20);
            this.txtKaProdi.TabIndex = 9;
            this.txtKaProdi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtSekProdi
            // 
            this.txtSekProdi.Location = new System.Drawing.Point(121, 171);
            this.txtSekProdi.Name = "txtSekProdi";
            this.txtSekProdi.Size = new System.Drawing.Size(100, 20);
            this.txtSekProdi.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(51, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(166, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSekProdi);
            this.Controls.Add(this.txtKaProdi);
            this.Controls.Add(this.txtSingkatan);
            this.Controls.Add(this.txtNamaProdi);
            this.Controls.Add(this.txtIdProdi);
            this.Controls.Add(this.lbSEK);
            this.Controls.Add(this.lbKAPRODI);
            this.Controls.Add(this.lbSINGKATAN);
            this.Controls.Add(this.lbNAMA);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Master program Studi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbNAMA;
        private System.Windows.Forms.Label lbSINGKATAN;
        private System.Windows.Forms.Label lbKAPRODI;
        private System.Windows.Forms.Label lbSEK;
        private System.Windows.Forms.TextBox txtIdProdi;
        private System.Windows.Forms.TextBox txtNamaProdi;
        private System.Windows.Forms.TextBox txtSingkatan;
        private System.Windows.Forms.TextBox txtKaProdi;
        private System.Windows.Forms.TextBox txtSekProdi;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}

