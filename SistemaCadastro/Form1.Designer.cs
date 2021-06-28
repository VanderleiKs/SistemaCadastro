
namespace SistemaCadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateNascimento = new System.Windows.Forms.DateTimePicker();
            this.comboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.checkCasa = new System.Windows.Forms.CheckBox();
            this.checkVeiculo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOutro = new System.Windows.Forms.RadioButton();
            this.radioFeminino = new System.Windows.Forms.RadioButton();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estado Civil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefone";
            // 
            // dateNascimento
            // 
            this.dateNascimento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateNascimento.Location = new System.Drawing.Point(210, 65);
            this.dateNascimento.Name = "dateNascimento";
            this.dateNascimento.Size = new System.Drawing.Size(429, 29);
            this.dateNascimento.TabIndex = 4;
            // 
            // comboEstadoCivil
            // 
            this.comboEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboEstadoCivil.FormattingEnabled = true;
            this.comboEstadoCivil.Location = new System.Drawing.Point(210, 103);
            this.comboEstadoCivil.Name = "comboEstadoCivil";
            this.comboEstadoCivil.Size = new System.Drawing.Size(307, 29);
            this.comboEstadoCivil.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.Location = new System.Drawing.Point(210, 141);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(307, 29);
            this.txtTelefone.TabIndex = 6;
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textNome.Location = new System.Drawing.Point(210, 27);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(429, 29);
            this.textNome.TabIndex = 8;
            // 
            // checkCasa
            // 
            this.checkCasa.AutoSize = true;
            this.checkCasa.Location = new System.Drawing.Point(210, 206);
            this.checkCasa.Name = "checkCasa";
            this.checkCasa.Size = new System.Drawing.Size(127, 19);
            this.checkCasa.TabIndex = 9;
            this.checkCasa.Text = "Possui casa própria";
            this.checkCasa.UseVisualStyleBackColor = true;
            // 
            // checkVeiculo
            // 
            this.checkVeiculo.AutoSize = true;
            this.checkVeiculo.Location = new System.Drawing.Point(210, 244);
            this.checkVeiculo.Name = "checkVeiculo";
            this.checkVeiculo.Size = new System.Drawing.Size(101, 19);
            this.checkVeiculo.TabIndex = 10;
            this.checkVeiculo.Text = "Possui veículo";
            this.checkVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOutro);
            this.groupBox1.Controls.Add(this.radioFeminino);
            this.groupBox1.Controls.Add(this.radioMasculino);
            this.groupBox1.Location = new System.Drawing.Point(210, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 62);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioOutro
            // 
            this.radioOutro.AutoSize = true;
            this.radioOutro.Location = new System.Drawing.Point(230, 22);
            this.radioOutro.Name = "radioOutro";
            this.radioOutro.Size = new System.Drawing.Size(56, 19);
            this.radioOutro.TabIndex = 2;
            this.radioOutro.TabStop = true;
            this.radioOutro.Text = "Outro";
            this.radioOutro.UseVisualStyleBackColor = true;
            // 
            // radioFeminino
            // 
            this.radioFeminino.AutoSize = true;
            this.radioFeminino.Location = new System.Drawing.Point(128, 22);
            this.radioFeminino.Name = "radioFeminino";
            this.radioFeminino.Size = new System.Drawing.Size(75, 19);
            this.radioFeminino.TabIndex = 1;
            this.radioFeminino.TabStop = true;
            this.radioFeminino.Text = "Feminino";
            this.radioFeminino.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Location = new System.Drawing.Point(21, 22);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(80, 19);
            this.radioMasculino.TabIndex = 0;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(30, 413);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(609, 88);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 506);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkVeiculo);
            this.Controls.Add(this.checkCasa);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.comboEstadoCivil);
            this.Controls.Add(this.dateNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateNascimento;
        private System.Windows.Forms.ComboBox comboEstadoCivil;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.CheckBox checkCasa;
        private System.Windows.Forms.CheckBox checkVeiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOutro;
        private System.Windows.Forms.RadioButton radioFeminino;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.ListBox listBox1;
    }
}

