namespace Traductor_Numerico
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OnScreen = new System.Windows.Forms.Panel();
            this.BotonHex = new System.Windows.Forms.Button();
            this.BotonDecimal = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonBinario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(111)))), ((int)(((byte)(99)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 41);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(26)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Traductor Númerico";
            // 
            // OnScreen
            // 
            this.OnScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.OnScreen.Location = new System.Drawing.Point(29, 236);
            this.OnScreen.Name = "OnScreen";
            this.OnScreen.Size = new System.Drawing.Size(772, 303);
            this.OnScreen.TabIndex = 1;
            // 
            // BotonHex
            // 
            this.BotonHex.FlatAppearance.BorderSize = 0;
            this.BotonHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonHex.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonHex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(202)))), ((int)(((byte)(198)))));
            this.BotonHex.Image = ((System.Drawing.Image)(resources.GetObject("BotonHex.Image")));
            this.BotonHex.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonHex.Location = new System.Drawing.Point(216, 39);
            this.BotonHex.Name = "BotonHex";
            this.BotonHex.Size = new System.Drawing.Size(97, 143);
            this.BotonHex.TabIndex = 3;
            this.BotonHex.Text = "Hexadecimal";
            this.BotonHex.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonHex.UseVisualStyleBackColor = true;
            this.BotonHex.Click += new System.EventHandler(this.BotonHex_Click);
            // 
            // BotonDecimal
            // 
            this.BotonDecimal.FlatAppearance.BorderSize = 0;
            this.BotonDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonDecimal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonDecimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(198)))));
            this.BotonDecimal.Image = ((System.Drawing.Image)(resources.GetObject("BotonDecimal.Image")));
            this.BotonDecimal.Location = new System.Drawing.Point(10, 39);
            this.BotonDecimal.Name = "BotonDecimal";
            this.BotonDecimal.Size = new System.Drawing.Size(97, 122);
            this.BotonDecimal.TabIndex = 1;
            this.BotonDecimal.Text = "Decimal";
            this.BotonDecimal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonDecimal.UseVisualStyleBackColor = true;
            this.BotonDecimal.Click += new System.EventHandler(this.BotonDecimal_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(8, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 33);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(202)))), ((int)(((byte)(198)))));
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sistema origen";
            // 
            // BotonBinario
            // 
            this.BotonBinario.FlatAppearance.BorderSize = 0;
            this.BotonBinario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBinario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBinario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(202)))), ((int)(((byte)(198)))));
            this.BotonBinario.Image = ((System.Drawing.Image)(resources.GetObject("BotonBinario.Image")));
            this.BotonBinario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonBinario.Location = new System.Drawing.Point(113, 39);
            this.BotonBinario.Name = "BotonBinario";
            this.BotonBinario.Size = new System.Drawing.Size(97, 122);
            this.BotonBinario.TabIndex = 4;
            this.BotonBinario.Text = "Binario";
            this.BotonBinario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BotonBinario.UseVisualStyleBackColor = true;
            this.BotonBinario.Click += new System.EventHandler(this.BotonBinario_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BotonBinario);
            this.panel2.Controls.Add(this.BotonHex);
            this.panel2.Controls.Add(this.BotonDecimal);
            this.panel2.Location = new System.Drawing.Point(8, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 185);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(856, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(825, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 24);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(38)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(891, 571);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OnScreen);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel OnScreen;
        private System.Windows.Forms.Button BotonHex;
        private System.Windows.Forms.Button BotonDecimal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonBinario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

