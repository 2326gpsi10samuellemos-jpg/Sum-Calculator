namespace somasuperiora100
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nrin = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_visuall = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira:";
            // 
            // tb_nrin
            // 
            this.tb_nrin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nrin.Location = new System.Drawing.Point(262, 76);
            this.tb_nrin.Name = "tb_nrin";
            this.tb_nrin.Size = new System.Drawing.Size(116, 35);
            this.tb_nrin.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(326, 401);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(103, 35);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_visuall
            // 
            this.lb_visuall.AutoSize = true;
            this.lb_visuall.Location = new System.Drawing.Point(39, 125);
            this.lb_visuall.Name = "lb_visuall";
            this.lb_visuall.Size = new System.Drawing.Size(51, 20);
            this.lb_visuall.TabIndex = 3;
            this.lb_visuall.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(435, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(43, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soma até 100";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_visuall);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_nrin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nrin;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_visuall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

