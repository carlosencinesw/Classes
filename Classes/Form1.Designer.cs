namespace Classes
{
    partial class Form1
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
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_falar = new System.Windows.Forms.Button();
            this.txt_fala = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_load = new System.Windows.Forms.TextBox();
            this.btn_carregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_01
            // 
            this.btn_01.Location = new System.Drawing.Point(276, 223);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(75, 23);
            this.btn_01.TabIndex = 0;
            this.btn_01.Text = "Fechar";
            this.btn_01.UseVisualStyleBackColor = true;
            this.btn_01.Click += new System.EventHandler(this.btn_01_Click);
            // 
            // btn_falar
            // 
            this.btn_falar.Location = new System.Drawing.Point(195, 223);
            this.btn_falar.Name = "btn_falar";
            this.btn_falar.Size = new System.Drawing.Size(75, 23);
            this.btn_falar.TabIndex = 2;
            this.btn_falar.Text = "Falar";
            this.btn_falar.UseVisualStyleBackColor = true;
            this.btn_falar.Click += new System.EventHandler(this.btn_falar_Click);
            // 
            // txt_fala
            // 
            this.txt_fala.Location = new System.Drawing.Point(12, 33);
            this.txt_fala.Name = "txt_fala";
            this.txt_fala.Size = new System.Drawing.Size(339, 20);
            this.txt_fala.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Falar algo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salvar Fala";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_load
            // 
            this.txt_load.Location = new System.Drawing.Point(12, 59);
            this.txt_load.Multiline = true;
            this.txt_load.Name = "txt_load";
            this.txt_load.ReadOnly = true;
            this.txt_load.Size = new System.Drawing.Size(339, 157);
            this.txt_load.TabIndex = 6;
            // 
            // btn_carregar
            // 
            this.btn_carregar.Location = new System.Drawing.Point(12, 222);
            this.btn_carregar.Name = "btn_carregar";
            this.btn_carregar.Size = new System.Drawing.Size(96, 23);
            this.btn_carregar.TabIndex = 7;
            this.btn_carregar.Text = "Carregar";
            this.btn_carregar.UseVisualStyleBackColor = true;
            this.btn_carregar.Click += new System.EventHandler(this.btn_carregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 258);
            this.Controls.Add(this.btn_carregar);
            this.Controls.Add(this.txt_load);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_fala);
            this.Controls.Add(this.btn_falar);
            this.Controls.Add(this.btn_01);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_falar;
        private System.Windows.Forms.TextBox txt_fala;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_load;
        private System.Windows.Forms.Button btn_carregar;
    }
}

