namespace UC11_AGENDA
{
    partial class AGENDA
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCADASTRAR = new System.Windows.Forms.Button();
            this.buttonALTERAR = new System.Windows.Forms.Button();
            this.buttonEXCLUIR = new System.Windows.Forms.Button();
            this.buttonPESQUISA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCADASTRAR
            // 
            this.buttonCADASTRAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCADASTRAR.Location = new System.Drawing.Point(205, 88);
            this.buttonCADASTRAR.Name = "buttonCADASTRAR";
            this.buttonCADASTRAR.Size = new System.Drawing.Size(380, 30);
            this.buttonCADASTRAR.TabIndex = 0;
            this.buttonCADASTRAR.Text = "cadastrar";
            this.buttonCADASTRAR.UseVisualStyleBackColor = true;
            this.buttonCADASTRAR.Click += new System.EventHandler(this.buttonCADASTRAR_Click);
            // 
            // buttonALTERAR
            // 
            this.buttonALTERAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonALTERAR.Location = new System.Drawing.Point(205, 148);
            this.buttonALTERAR.Name = "buttonALTERAR";
            this.buttonALTERAR.Size = new System.Drawing.Size(380, 30);
            this.buttonALTERAR.TabIndex = 1;
            this.buttonALTERAR.Text = "alterar";
            this.buttonALTERAR.UseVisualStyleBackColor = true;
            // 
            // buttonEXCLUIR
            // 
            this.buttonEXCLUIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXCLUIR.Location = new System.Drawing.Point(205, 210);
            this.buttonEXCLUIR.Name = "buttonEXCLUIR";
            this.buttonEXCLUIR.Size = new System.Drawing.Size(380, 30);
            this.buttonEXCLUIR.TabIndex = 2;
            this.buttonEXCLUIR.Text = "excluir";
            this.buttonEXCLUIR.UseVisualStyleBackColor = true;
            // 
            // buttonPESQUISA
            // 
            this.buttonPESQUISA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPESQUISA.Location = new System.Drawing.Point(205, 272);
            this.buttonPESQUISA.Name = "buttonPESQUISA";
            this.buttonPESQUISA.Size = new System.Drawing.Size(380, 30);
            this.buttonPESQUISA.TabIndex = 3;
            this.buttonPESQUISA.Text = "pesquisar";
            this.buttonPESQUISA.UseVisualStyleBackColor = true;
            // 
            // AGENDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPESQUISA);
            this.Controls.Add(this.buttonEXCLUIR);
            this.Controls.Add(this.buttonALTERAR);
            this.Controls.Add(this.buttonCADASTRAR);
            this.Name = "AGENDA";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCADASTRAR;
        private System.Windows.Forms.Button buttonALTERAR;
        private System.Windows.Forms.Button buttonEXCLUIR;
        private System.Windows.Forms.Button buttonPESQUISA;
    }
}

