namespace LJMSOFT.View.PessoaView.PessoaComplemento
{
    partial class PessoaRamoAtividade
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
            this.codigoBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ramoAtividadeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // codigoBox
            // 
            this.codigoBox.Enabled = false;
            this.codigoBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoBox.Location = new System.Drawing.Point(343, 42);
            this.codigoBox.Multiline = false;
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.codigoBox.Size = new System.Drawing.Size(74, 26);
            this.codigoBox.TabIndex = 52;
            this.codigoBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Código";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Ramo de atividade";
            // 
            // ramoAtividadeBox
            // 
            this.ramoAtividadeBox.Enabled = false;
            this.ramoAtividadeBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ramoAtividadeBox.Location = new System.Drawing.Point(55, 42);
            this.ramoAtividadeBox.Multiline = false;
            this.ramoAtividadeBox.Name = "ramoAtividadeBox";
            this.ramoAtividadeBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ramoAtividadeBox.Size = new System.Drawing.Size(218, 26);
            this.ramoAtividadeBox.TabIndex = 53;
            this.ramoAtividadeBox.Text = "";
            // 
            // PessoaRamoAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 101);
            this.Controls.Add(this.ramoAtividadeBox);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Name = "PessoaRamoAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PessoaComplementoTela";
            this.Load += new System.EventHandler(this.PessoaComplementoTela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox codigoBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox ramoAtividadeBox;
    }
}