namespace Calculadora_v2
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
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_mult = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.textresult = new System.Windows.Forms.TextBox();
            this.textval1 = new System.Windows.Forms.TextBox();
            this.textval2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(198, 92);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(44, 31);
            this.btn_soma.TabIndex = 0;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_mult
            // 
            this.btn_mult.Location = new System.Drawing.Point(198, 168);
            this.btn_mult.Name = "btn_mult";
            this.btn_mult.Size = new System.Drawing.Size(44, 31);
            this.btn_mult.TabIndex = 1;
            this.btn_mult.Text = "x";
            this.btn_mult.UseVisualStyleBackColor = true;
            this.btn_mult.Click += new System.EventHandler(this.btn_mult_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(198, 205);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(44, 31);
            this.btn_div.TabIndex = 2;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(198, 131);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(44, 31);
            this.btn_sub.TabIndex = 3;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_result
            // 
            this.btn_result.Location = new System.Drawing.Point(248, 92);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(54, 144);
            this.btn_result.TabIndex = 4;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // textresult
            // 
            this.textresult.Location = new System.Drawing.Point(40, 45);
            this.textresult.Name = "textresult";
            this.textresult.Size = new System.Drawing.Size(262, 23);
            this.textresult.TabIndex = 5;
            // 
            // textval1
            // 
            this.textval1.Location = new System.Drawing.Point(41, 122);
            this.textval1.Name = "textval1";
            this.textval1.Size = new System.Drawing.Size(128, 23);
            this.textval1.TabIndex = 6;
            // 
            // textval2
            // 
            this.textval2.Location = new System.Drawing.Point(40, 180);
            this.textval2.Name = "textval2";
            this.textval2.Size = new System.Drawing.Size(129, 23);
            this.textval2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Digite o primeiro valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Digite o segundo valor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculadora_v2.Properties.Resources.a1754fe7952721f74d5fd2dd565f5013;
            this.ClientSize = new System.Drawing.Size(337, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textval2);
            this.Controls.Add(this.textval1);
            this.Controls.Add(this.textresult);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mult);
            this.Controls.Add(this.btn_soma);
            this.Name = "Form1";
            this.Text = "SmartCalc 2000";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_soma;
        private Button btn_mult;
        private Button btn_div;
        private Button btn_sub;
        private Button btn_result;
        private TextBox textresult;
        private TextBox textval1;
        private TextBox textval2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}