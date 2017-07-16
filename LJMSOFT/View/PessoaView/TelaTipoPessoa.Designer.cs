namespace LJMSOFT.View
{
    partial class TelaTipoPessoa
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
            this.apelidoBox = new System.Windows.Forms.RichTextBox();
            this.tipoCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.codigoBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.setorAtividadeCombo = new System.Windows.Forms.ComboBox();
            this.nomeBox = new System.Windows.Forms.RichTextBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.liberarButton = new System.Windows.Forms.Button();
            this.voltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apelidoBox
            // 
            this.apelidoBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apelidoBox.Location = new System.Drawing.Point(-306, -53);
            this.apelidoBox.Multiline = false;
            this.apelidoBox.Name = "apelidoBox";
            this.apelidoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.apelidoBox.Size = new System.Drawing.Size(242, 26);
            this.apelidoBox.TabIndex = 49;
            this.apelidoBox.Text = "";
            // 
            // tipoCombo
            // 
            this.tipoCombo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tipoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipoCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoCombo.Location = new System.Drawing.Point(-303, 14);
            this.tipoCombo.MaxDropDownItems = 99;
            this.tipoCombo.Name = "tipoCombo";
            this.tipoCombo.Size = new System.Drawing.Size(121, 26);
            this.tipoCombo.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-306, -15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-306, -82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Apelido/Nome Fantasia";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(-303, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 38;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(636, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Código";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(306, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Alçada de aprovação";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(58, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 17);
            this.label14.TabIndex = 52;
            this.label14.Text = "Nome";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(61, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 51;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codigoBox
            // 
            this.codigoBox.Enabled = false;
            this.codigoBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoBox.Location = new System.Drawing.Point(639, 86);
            this.codigoBox.Multiline = false;
            this.codigoBox.Name = "codigoBox";
            this.codigoBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.codigoBox.Size = new System.Drawing.Size(74, 26);
            this.codigoBox.TabIndex = 65;
            this.codigoBox.Text = "";
            this.codigoBox.TextChanged += new System.EventHandler(this.richTextBox6_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Location = new System.Drawing.Point(61, 151);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(652, 178);
            this.richTextBox2.TabIndex = 66;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // setorAtividadeCombo
            // 
            this.setorAtividadeCombo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.setorAtividadeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.setorAtividadeCombo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.setorAtividadeCombo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setorAtividadeCombo.FormattingEnabled = true;
            this.setorAtividadeCombo.Location = new System.Drawing.Point(309, 86);
            this.setorAtividadeCombo.Name = "setorAtividadeCombo";
            this.setorAtividadeCombo.Size = new System.Drawing.Size(243, 26);
            this.setorAtividadeCombo.TabIndex = 67;
            // 
            // nomeBox
            // 
            this.nomeBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeBox.Location = new System.Drawing.Point(61, 86);
            this.nomeBox.Multiline = false;
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.nomeBox.Size = new System.Drawing.Size(227, 26);
            this.nomeBox.TabIndex = 68;
            this.nomeBox.Text = "";
            this.nomeBox.TextChanged += new System.EventHandler(this.nomeBox_TextChanged);
            // 
            // gravarButton
            // 
            this.gravarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gravarButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gravarButton.Location = new System.Drawing.Point(519, 353);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(96, 34);
            this.gravarButton.TabIndex = 69;
            this.gravarButton.Text = "Gravar";
            this.gravarButton.UseCompatibleTextRendering = true;
            this.gravarButton.UseVisualStyleBackColor = true;
            this.gravarButton.Click += new System.EventHandler(this.gravarButton_Click);
            // 
            // liberarButton
            // 
            this.liberarButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.liberarButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liberarButton.Location = new System.Drawing.Point(617, 353);
            this.liberarButton.Name = "liberarButton";
            this.liberarButton.Size = new System.Drawing.Size(96, 34);
            this.liberarButton.TabIndex = 70;
            this.liberarButton.Text = "Liberar";
            this.liberarButton.UseVisualStyleBackColor = true;
            this.liberarButton.Click += new System.EventHandler(this.liberarButton_Click);
            // 
            // voltarButton
            // 
            this.voltarButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltarButton.Location = new System.Drawing.Point(520, 353);
            this.voltarButton.Name = "voltarButton";
            this.voltarButton.Size = new System.Drawing.Size(96, 34);
            this.voltarButton.TabIndex = 71;
            this.voltarButton.Text = "Voltar";
            this.voltarButton.UseVisualStyleBackColor = true;
            this.voltarButton.Click += new System.EventHandler(this.voltarButton_Click);
            // 
            // TelaTipoPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(768, 412);
            this.Controls.Add(this.voltarButton);
            this.Controls.Add(this.liberarButton);
            this.Controls.Add(this.gravarButton);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.setorAtividadeCombo);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.codigoBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.apelidoBox);
            this.Controls.Add(this.tipoCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TelaTipoPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaTipoPessoa";
            this.Load += new System.EventHandler(this.TelaTipoPessoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox apelidoBox;
        private System.Windows.Forms.ComboBox tipoCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox codigoBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox setorAtividadeCombo;
        private System.Windows.Forms.RichTextBox nomeBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button liberarButton;
        private System.Windows.Forms.Button voltarButton;
    }
}