namespace TesteBrunsker
{
    partial class Form2
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textCEP = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textUF = new System.Windows.Forms.TextBox();
            this.buttonCEP = new System.Windows.Forms.Button();
            this.buttonRetorno = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboSituacao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Novo Imóvel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(365, 265);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(172, 39);
            this.buttonCadastrar.TabIndex = 1;
            this.buttonCadastrar.Text = "CADASTRAR";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CEP:";
            // 
            // textCEP
            // 
            this.textCEP.Location = new System.Drawing.Point(75, 77);
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(175, 20);
            this.textCEP.TabIndex = 5;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(75, 128);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(542, 20);
            this.textEndereco.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Endereço: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "UF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo:";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(75, 198);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(156, 21);
            this.comboTipo.TabIndex = 14;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(75, 161);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(281, 20);
            this.textCidade.TabIndex = 15;
            // 
            // textUF
            // 
            this.textUF.Location = new System.Drawing.Point(392, 162);
            this.textUF.Name = "textUF";
            this.textUF.Size = new System.Drawing.Size(224, 20);
            this.textUF.TabIndex = 16;
            // 
            // buttonCEP
            // 
            this.buttonCEP.Location = new System.Drawing.Point(265, 76);
            this.buttonCEP.Name = "buttonCEP";
            this.buttonCEP.Size = new System.Drawing.Size(155, 22);
            this.buttonCEP.TabIndex = 17;
            this.buttonCEP.Text = "Buscar endereço pelo CEP";
            this.buttonCEP.UseVisualStyleBackColor = true;
            this.buttonCEP.Click += new System.EventHandler(this.buttonCEP_Click);
            // 
            // buttonRetorno
            // 
            this.buttonRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetorno.Location = new System.Drawing.Point(239, 281);
            this.buttonRetorno.Name = "buttonRetorno";
            this.buttonRetorno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRetorno.Size = new System.Drawing.Size(103, 23);
            this.buttonRetorno.TabIndex = 18;
            this.buttonRetorno.Text = "Retornar";
            this.buttonRetorno.UseVisualStyleBackColor = true;
            this.buttonRetorno.Click += new System.EventHandler(this.buttonRetorno_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(270, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Situação";
            // 
            // comboSituacao
            // 
            this.comboSituacao.FormattingEnabled = true;
            this.comboSituacao.Location = new System.Drawing.Point(321, 200);
            this.comboSituacao.Name = "comboSituacao";
            this.comboSituacao.Size = new System.Drawing.Size(177, 21);
            this.comboSituacao.TabIndex = 39;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 326);
            this.Controls.Add(this.comboSituacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonRetorno);
            this.Controls.Add(this.buttonCEP);
            this.Controls.Add(this.textUF);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textCEP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Cadastro Novo Imóvel";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCEP;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textUF;
        private System.Windows.Forms.Button buttonCEP;
        private System.Windows.Forms.Button buttonRetorno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboSituacao;
    }
}