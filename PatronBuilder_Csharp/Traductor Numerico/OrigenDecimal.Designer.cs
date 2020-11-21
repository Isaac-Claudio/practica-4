namespace Traductor_Numerico
{
    partial class OrigenDecimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrigenDecimal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Traduccion_Binaria = new System.Windows.Forms.Panel();
            this.Resultado_Binario = new System.Windows.Forms.Label();
            this.Traducir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Resultado_Hexadecimal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Traduccion_Binaria.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(52)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.Traducir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Input);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 102);
            this.panel1.TabIndex = 1;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(29, 39);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(586, 46);
            this.Input.TabIndex = 0;
            this.Input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduzca texto en formato Decimal";
            // 
            // Traduccion_Binaria
            // 
            this.Traduccion_Binaria.Controls.Add(this.label2);
            this.Traduccion_Binaria.Controls.Add(this.Resultado_Binario);
            this.Traduccion_Binaria.Location = new System.Drawing.Point(83, 135);
            this.Traduccion_Binaria.Name = "Traduccion_Binaria";
            this.Traduccion_Binaria.Size = new System.Drawing.Size(200, 100);
            this.Traduccion_Binaria.TabIndex = 2;
            // 
            // Resultado_Binario
            // 
            this.Resultado_Binario.AutoSize = true;
            this.Resultado_Binario.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado_Binario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(198)))));
            this.Resultado_Binario.Location = new System.Drawing.Point(21, 54);
            this.Resultado_Binario.Name = "Resultado_Binario";
            this.Resultado_Binario.Size = new System.Drawing.Size(0, 25);
            this.Resultado_Binario.TabIndex = 0;
            // 
            // Traducir
            // 
            this.Traducir.FlatAppearance.BorderSize = 0;
            this.Traducir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Traducir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(198)))));
            this.Traducir.Image = ((System.Drawing.Image)(resources.GetObject("Traducir.Image")));
            this.Traducir.Location = new System.Drawing.Point(621, 39);
            this.Traducir.Name = "Traducir";
            this.Traducir.Size = new System.Drawing.Size(64, 45);
            this.Traducir.TabIndex = 4;
            this.Traducir.Text = "Traducir";
            this.Traducir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Traducir.UseVisualStyleBackColor = true;
            this.Traducir.Click += new System.EventHandler(this.Traducir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Resultado_Hexadecimal);
            this.panel2.Location = new System.Drawing.Point(440, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // Resultado_Hexadecimal
            // 
            this.Resultado_Hexadecimal.AutoSize = true;
            this.Resultado_Hexadecimal.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado_Hexadecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(198)))));
            this.Resultado_Hexadecimal.Location = new System.Drawing.Point(21, 54);
            this.Resultado_Hexadecimal.Name = "Resultado_Hexadecimal";
            this.Resultado_Hexadecimal.Size = new System.Drawing.Size(0, 25);
            this.Resultado_Hexadecimal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(198)))));
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Binario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(198)))));
            this.label3.Location = new System.Drawing.Point(10, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Hexadecimal:";
            // 
            // OrigenDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(64)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(772, 303);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Traduccion_Binaria);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrigenDecimal";
            this.Text = "OrigenDecimal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Traduccion_Binaria.ResumeLayout(false);
            this.Traduccion_Binaria.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Traduccion_Binaria;
        private System.Windows.Forms.Label Resultado_Binario;
        private System.Windows.Forms.Button Traducir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Resultado_Hexadecimal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}