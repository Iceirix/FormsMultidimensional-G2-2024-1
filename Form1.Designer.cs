﻿namespace FormsMultidimensional_G2_2024_1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnIntro = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtbDisplay = new System.Windows.Forms.TextBox();
            this.rdbRad = new System.Windows.Forms.RadioButton();
            this.rdbDeg = new System.Windows.Forms.RadioButton();
            this.lbMatriz1 = new System.Windows.Forms.Label();
            this.lbMatriz2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(212, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(322, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 0;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(434, 317);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 39);
            this.button3.TabIndex = 0;
            this.button3.Text = "x";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIntro
            // 
            this.btnIntro.BackColor = System.Drawing.Color.SpringGreen;
            this.btnIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntro.Location = new System.Drawing.Point(532, 317);
            this.btnIntro.Name = "btnIntro";
            this.btnIntro.Size = new System.Drawing.Size(75, 106);
            this.btnIntro.TabIndex = 0;
            this.btnIntro.Text = "In";
            this.btnIntro.UseVisualStyleBackColor = false;
            this.btnIntro.Click += new System.EventHandler(this.btnIntro_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(212, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "sen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(322, 384);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 39);
            this.button5.TabIndex = 0;
            this.button5.Text = "T";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(434, 384);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 39);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtbDisplay
            // 
            this.txtbDisplay.Location = new System.Drawing.Point(212, 101);
            this.txtbDisplay.Name = "txtbDisplay";
            this.txtbDisplay.Size = new System.Drawing.Size(395, 20);
            this.txtbDisplay.TabIndex = 1;
            // 
            // rdbRad
            // 
            this.rdbRad.AutoSize = true;
            this.rdbRad.Location = new System.Drawing.Point(212, 40);
            this.rdbRad.Name = "rdbRad";
            this.rdbRad.Size = new System.Drawing.Size(40, 17);
            this.rdbRad.TabIndex = 2;
            this.rdbRad.TabStop = true;
            this.rdbRad.Text = "rad";
            this.rdbRad.UseVisualStyleBackColor = true;
            // 
            // rdbDeg
            // 
            this.rdbDeg.AutoSize = true;
            this.rdbDeg.Location = new System.Drawing.Point(354, 40);
            this.rdbDeg.Name = "rdbDeg";
            this.rdbDeg.Size = new System.Drawing.Size(43, 17);
            this.rdbDeg.TabIndex = 2;
            this.rdbDeg.TabStop = true;
            this.rdbDeg.Text = "deg";
            this.rdbDeg.UseVisualStyleBackColor = true;
            // 
            // lbMatriz1
            // 
            this.lbMatriz1.Location = new System.Drawing.Point(209, 198);
            this.lbMatriz1.Name = "lbMatriz1";
            this.lbMatriz1.Size = new System.Drawing.Size(70, 70);
            this.lbMatriz1.TabIndex = 3;
            this.lbMatriz1.Text = "0";
            // 
            // lbMatriz2
            // 
            this.lbMatriz2.Location = new System.Drawing.Point(370, 198);
            this.lbMatriz2.Name = "lbMatriz2";
            this.lbMatriz2.Size = new System.Drawing.Size(70, 70);
            this.lbMatriz2.TabIndex = 3;
            this.lbMatriz2.Text = "0";
            // 
            // lbResultado
            // 
            this.lbResultado.Location = new System.Drawing.Point(526, 198);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(70, 70);
            this.lbResultado.TabIndex = 3;
            this.lbResultado.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Matriz 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Matriz 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(526, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 604);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMatriz2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMatriz1);
            this.Controls.Add(this.rdbDeg);
            this.Controls.Add(this.rdbRad);
            this.Controls.Add(this.txtbDisplay);
            this.Controls.Add(this.btnIntro);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnIntro;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtbDisplay;
        private System.Windows.Forms.RadioButton rdbRad;
        private System.Windows.Forms.RadioButton rdbDeg;
        private System.Windows.Forms.Label lbMatriz1;
        private System.Windows.Forms.Label lbMatriz2;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

