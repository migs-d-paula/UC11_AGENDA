namespace UC11_AGENDA
{
    partial class PESQUISA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PESQUISA));
            this.dataGridViewPESQUISA = new System.Windows.Forms.DataGridView();
            this.textBoxPESQUISA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPESQUISAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPESQUISA)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPESQUISA
            // 
            this.dataGridViewPESQUISA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPESQUISA.Location = new System.Drawing.Point(12, 135);
            this.dataGridViewPESQUISA.Name = "dataGridViewPESQUISA";
            this.dataGridViewPESQUISA.Size = new System.Drawing.Size(879, 426);
            this.dataGridViewPESQUISA.TabIndex = 0;
            // 
            // textBoxPESQUISA
            // 
            this.textBoxPESQUISA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPESQUISA.Location = new System.Drawing.Point(12, 65);
            this.textBoxPESQUISA.Name = "textBoxPESQUISA";
            this.textBoxPESQUISA.Size = new System.Drawing.Size(780, 23);
            this.textBoxPESQUISA.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(829, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "atualizar";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonPESQUISAR
            // 
            this.buttonPESQUISAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPESQUISAR.Location = new System.Drawing.Point(816, 65);
            this.buttonPESQUISAR.Name = "buttonPESQUISAR";
            this.buttonPESQUISAR.Size = new System.Drawing.Size(75, 23);
            this.buttonPESQUISAR.TabIndex = 5;
            this.buttonPESQUISAR.Text = "Pesquisar";
            this.buttonPESQUISAR.UseVisualStyleBackColor = true;
            this.buttonPESQUISAR.Click += new System.EventHandler(this.buttonPESQUISAR_Click);
            // 
            // PESQUISA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(902, 573);
            this.Controls.Add(this.buttonPESQUISAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPESQUISA);
            this.Controls.Add(this.dataGridViewPESQUISA);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PESQUISA";
            this.Text = "pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPESQUISA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPESQUISA;
        private System.Windows.Forms.TextBox textBoxPESQUISA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPESQUISAR;
    }
}