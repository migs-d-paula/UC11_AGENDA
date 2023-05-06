namespace UC11_AGENDA
{
    partial class EXCLUIR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EXCLUIR));
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEXCLUIR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSOBRENOME = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(114, 54);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(353, 20);
            this.textBoxID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(87, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id :";
            // 
            // buttonEXCLUIR
            // 
            this.buttonEXCLUIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEXCLUIR.Location = new System.Drawing.Point(219, 237);
            this.buttonEXCLUIR.Name = "buttonEXCLUIR";
            this.buttonEXCLUIR.Size = new System.Drawing.Size(117, 33);
            this.buttonEXCLUIR.TabIndex = 2;
            this.buttonEXCLUIR.Text = "Excluir";
            this.buttonEXCLUIR.UseVisualStyleBackColor = true;
            this.buttonEXCLUIR.Click += new System.EventHandler(this.buttonEXCLUIR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(69, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nome :";
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(114, 111);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(353, 20);
            this.textBoxNOME.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "sobrenome :";
            // 
            // textBoxSOBRENOME
            // 
            this.textBoxSOBRENOME.Location = new System.Drawing.Point(114, 168);
            this.textBoxSOBRENOME.Name = "textBoxSOBRENOME";
            this.textBoxSOBRENOME.Size = new System.Drawing.Size(353, 20);
            this.textBoxSOBRENOME.TabIndex = 7;
            // 
            // EXCLUIR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(553, 341);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSOBRENOME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNOME);
            this.Controls.Add(this.buttonEXCLUIR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EXCLUIR";
            this.Text = "EXCLUIR";
            this.Load += new System.EventHandler(this.EXCLUIR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEXCLUIR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSOBRENOME;
    }
}