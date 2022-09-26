namespace Aula006
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblmensagem = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnbranco = new System.Windows.Forms.Button();
            this.btncorrige = new System.Windows.Forms.Button();
            this.btnconfirma = new System.Windows.Forms.Button();
            this.lblcanditato = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblturma = new System.Windows.Forms.Label();
            this.pxfoto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.lblmensagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pxfoto);
            this.panel1.Controls.Add(this.lblturma);
            this.panel1.Controls.Add(this.lblcanditato);
            this.panel1.Controls.Add(this.txtNum2);
            this.panel1.Controls.Add(this.txtNum1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 275);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnconfirma);
            this.panel2.Controls.Add(this.btncorrige);
            this.panel2.Controls.Add(this.btnbranco);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Location = new System.Drawing.Point(534, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 311);
            this.panel2.TabIndex = 2;
            // 
            // lblmensagem
            // 
            this.lblmensagem.Controls.Add(this.label6);
            this.lblmensagem.Controls.Add(this.label5);
            this.lblmensagem.Location = new System.Drawing.Point(12, 320);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(476, 75);
            this.lblmensagem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "URNA ELETRÔNICA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SEU VOTO PARA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "REPRESENTANTE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NÚMERO";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(98, 155);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(27, 26);
            this.txtNum1.TabIndex = 6;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(131, 155);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(27, 26);
            this.txtNum2.TabIndex = 7;
            this.txtNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(33, 41);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(52, 30);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(104, 41);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(52, 30);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(178, 41);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(52, 30);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(178, 88);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(52, 30);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(104, 88);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(52, 30);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(33, 88);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(52, 30);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(178, 132);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(52, 30);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(104, 132);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(52, 30);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(33, 132);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(52, 30);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(104, 182);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(52, 30);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnbranco
            // 
            this.btnbranco.Location = new System.Drawing.Point(16, 243);
            this.btnbranco.Name = "btnbranco";
            this.btnbranco.Size = new System.Drawing.Size(69, 39);
            this.btnbranco.TabIndex = 8;
            this.btnbranco.Text = "BRANCO";
            this.btnbranco.UseVisualStyleBackColor = true;
            // 
            // btncorrige
            // 
            this.btncorrige.BackColor = System.Drawing.Color.Lime;
            this.btncorrige.Location = new System.Drawing.Point(91, 243);
            this.btncorrige.Name = "btncorrige";
            this.btncorrige.Size = new System.Drawing.Size(69, 39);
            this.btncorrige.TabIndex = 10;
            this.btncorrige.Text = "CORRIGE";
            this.btncorrige.UseVisualStyleBackColor = false;
            // 
            // btnconfirma
            // 
            this.btnconfirma.BackColor = System.Drawing.Color.Green;
            this.btnconfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirma.Location = new System.Drawing.Point(166, 243);
            this.btnconfirma.Name = "btnconfirma";
            this.btnconfirma.Size = new System.Drawing.Size(74, 39);
            this.btnconfirma.TabIndex = 11;
            this.btnconfirma.Text = "CONFIRMA";
            this.btnconfirma.UseVisualStyleBackColor = false;
            // 
            // lblcanditato
            // 
            this.lblcanditato.AutoSize = true;
            this.lblcanditato.Location = new System.Drawing.Point(100, 210);
            this.lblcanditato.Name = "lblcanditato";
            this.lblcanditato.Size = new System.Drawing.Size(0, 13);
            this.lblcanditato.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "TECLE VERDE PARA CONFIRMAR";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "TECLE LARANNJA PARA CORRIGIR";
            // 
            // lblturma
            // 
            this.lblturma.AutoSize = true;
            this.lblturma.Location = new System.Drawing.Point(100, 233);
            this.lblturma.Name = "lblturma";
            this.lblturma.Size = new System.Drawing.Size(0, 13);
            this.lblturma.TabIndex = 9;
            // 
            // pxfoto
            // 
            this.pxfoto.Location = new System.Drawing.Point(266, 44);
            this.pxfoto.Name = "pxfoto";
            this.pxfoto.Size = new System.Drawing.Size(155, 202);
            this.pxfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxfoto.TabIndex = 10;
            this.pxfoto.TabStop = false;
            this.pxfoto.Click += new System.EventHandler(this.pxfoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.lblmensagem.ResumeLayout(false);
            this.lblmensagem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel lblmensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnconfirma;
        private System.Windows.Forms.Button btncorrige;
        private System.Windows.Forms.Button btnbranco;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblcanditato;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pxfoto;
        private System.Windows.Forms.Label lblturma;
    }
}

