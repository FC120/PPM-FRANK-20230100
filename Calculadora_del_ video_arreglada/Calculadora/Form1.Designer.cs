
namespace Calculadora
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
            txtResultado = new System.Windows.Forms.TextBox();
            btnUno = new System.Windows.Forms.Button();
            btnDos = new System.Windows.Forms.Button();
            btnTres = new System.Windows.Forms.Button();
            btnSeis = new System.Windows.Forms.Button();
            btnCinco = new System.Windows.Forms.Button();
            btnCuatro = new System.Windows.Forms.Button();
            btnQuitar = new System.Windows.Forms.Button();
            btnBorrarTodo = new System.Windows.Forms.Button();
            btnBorrar = new System.Windows.Forms.Button();
            btnNueve = new System.Windows.Forms.Button();
            btnOcho = new System.Windows.Forms.Button();
            btnSiete = new System.Windows.Forms.Button();
            btnCuadrado = new System.Windows.Forms.Button();
            btnRaizCuadrada = new System.Windows.Forms.Button();
            btnMultiplicar = new System.Windows.Forms.Button();
            btnDividir = new System.Windows.Forms.Button();
            btnRestar = new System.Windows.Forms.Button();
            btnSumar = new System.Windows.Forms.Button();
            btnResultado = new System.Windows.Forms.Button();
            btnPunto = new System.Windows.Forms.Button();
            btnCero = new System.Windows.Forms.Button();
            btnSigno = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Font = new System.Drawing.Font("Goudy Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtResultado.Location = new System.Drawing.Point(13, 13);
            txtResultado.MaxLength = 21;
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new System.Drawing.Size(281, 45);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "0";
            txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnUno
            // 
            btnUno.BackColor = System.Drawing.Color.GhostWhite;
            btnUno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnUno.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUno.Location = new System.Drawing.Point(13, 249);
            btnUno.Name = "btnUno";
            btnUno.Size = new System.Drawing.Size(45, 45);
            btnUno.TabIndex = 1;
            btnUno.Text = "1";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += agregarNumero;
            // 
            // btnDos
            // 
            btnDos.BackColor = System.Drawing.Color.GhostWhite;
            btnDos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDos.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDos.Location = new System.Drawing.Point(70, 249);
            btnDos.Name = "btnDos";
            btnDos.Size = new System.Drawing.Size(45, 45);
            btnDos.TabIndex = 2;
            btnDos.Text = "2";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += agregarNumero;
            // 
            // btnTres
            // 
            btnTres.BackColor = System.Drawing.Color.GhostWhite;
            btnTres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnTres.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnTres.Location = new System.Drawing.Point(127, 249);
            btnTres.Name = "btnTres";
            btnTres.Size = new System.Drawing.Size(45, 45);
            btnTres.TabIndex = 3;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += agregarNumero;
            // 
            // btnSeis
            // 
            btnSeis.BackColor = System.Drawing.Color.GhostWhite;
            btnSeis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSeis.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSeis.Location = new System.Drawing.Point(127, 190);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new System.Drawing.Size(45, 45);
            btnSeis.TabIndex = 6;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = false;
            btnSeis.Click += agregarNumero;
            // 
            // btnCinco
            // 
            btnCinco.BackColor = System.Drawing.Color.GhostWhite;
            btnCinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCinco.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCinco.Location = new System.Drawing.Point(70, 190);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new System.Drawing.Size(45, 45);
            btnCinco.TabIndex = 5;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = false;
            btnCinco.Click += agregarNumero;
            // 
            // btnCuatro
            // 
            btnCuatro.BackColor = System.Drawing.Color.GhostWhite;
            btnCuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCuatro.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCuatro.Location = new System.Drawing.Point(13, 190);
            btnCuatro.Name = "btnCuatro";
            btnCuatro.Size = new System.Drawing.Size(45, 45);
            btnCuatro.TabIndex = 4;
            btnCuatro.Text = "4";
            btnCuatro.UseVisualStyleBackColor = false;
            btnCuatro.Click += agregarNumero;
            // 
            // btnQuitar
            // 
            btnQuitar.BackColor = System.Drawing.Color.Red;
            btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnQuitar.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnQuitar.Location = new System.Drawing.Point(127, 71);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new System.Drawing.Size(45, 45);
            btnQuitar.TabIndex = 12;
            btnQuitar.Text = "<-";
            btnQuitar.UseVisualStyleBackColor = false;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.BackColor = System.Drawing.Color.Red;
            btnBorrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBorrarTodo.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBorrarTodo.Location = new System.Drawing.Point(70, 71);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new System.Drawing.Size(45, 45);
            btnBorrarTodo.TabIndex = 11;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = false;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = System.Drawing.Color.Red;
            btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnBorrar.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBorrar.Location = new System.Drawing.Point(13, 71);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(45, 45);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "CE";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnNueve
            // 
            btnNueve.BackColor = System.Drawing.Color.GhostWhite;
            btnNueve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnNueve.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNueve.Location = new System.Drawing.Point(127, 131);
            btnNueve.Name = "btnNueve";
            btnNueve.Size = new System.Drawing.Size(45, 45);
            btnNueve.TabIndex = 9;
            btnNueve.Text = "9";
            btnNueve.UseVisualStyleBackColor = false;
            btnNueve.Click += agregarNumero;
            // 
            // btnOcho
            // 
            btnOcho.BackColor = System.Drawing.Color.GhostWhite;
            btnOcho.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnOcho.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnOcho.Location = new System.Drawing.Point(70, 131);
            btnOcho.Name = "btnOcho";
            btnOcho.Size = new System.Drawing.Size(45, 45);
            btnOcho.TabIndex = 8;
            btnOcho.Text = "8";
            btnOcho.UseVisualStyleBackColor = false;
            btnOcho.Click += agregarNumero;
            // 
            // btnSiete
            // 
            btnSiete.BackColor = System.Drawing.Color.GhostWhite;
            btnSiete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSiete.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSiete.Location = new System.Drawing.Point(13, 131);
            btnSiete.Name = "btnSiete";
            btnSiete.Size = new System.Drawing.Size(45, 45);
            btnSiete.TabIndex = 7;
            btnSiete.Text = "7";
            btnSiete.UseVisualStyleBackColor = false;
            btnSiete.Click += agregarNumero;
            // 
            // btnCuadrado
            // 
            btnCuadrado.BackColor = System.Drawing.Color.Blue;
            btnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCuadrado.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCuadrado.Location = new System.Drawing.Point(244, 71);
            btnCuadrado.Name = "btnCuadrado";
            btnCuadrado.Size = new System.Drawing.Size(45, 45);
            btnCuadrado.TabIndex = 14;
            btnCuadrado.Tag = "²";
            btnCuadrado.Text = "x²";
            btnCuadrado.UseVisualStyleBackColor = false;
            btnCuadrado.Click += clickOperador;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.BackColor = System.Drawing.Color.Blue;
            btnRaizCuadrada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRaizCuadrada.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRaizCuadrada.Location = new System.Drawing.Point(187, 71);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new System.Drawing.Size(45, 45);
            btnRaizCuadrada.TabIndex = 13;
            btnRaizCuadrada.Tag = "√";
            btnRaizCuadrada.Text = "√";
            btnRaizCuadrada.UseVisualStyleBackColor = false;
            btnRaizCuadrada.Click += clickOperador;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = System.Drawing.Color.Blue;
            btnMultiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnMultiplicar.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnMultiplicar.Location = new System.Drawing.Point(244, 131);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new System.Drawing.Size(45, 45);
            btnMultiplicar.TabIndex = 16;
            btnMultiplicar.Tag = "X";
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += clickOperador;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = System.Drawing.Color.Blue;
            btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDividir.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDividir.Location = new System.Drawing.Point(187, 131);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new System.Drawing.Size(45, 45);
            btnDividir.TabIndex = 15;
            btnDividir.Tag = "∕";
            btnDividir.Text = "∕";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += clickOperador;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = System.Drawing.Color.Blue;
            btnRestar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnRestar.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnRestar.Location = new System.Drawing.Point(244, 190);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new System.Drawing.Size(45, 45);
            btnRestar.TabIndex = 18;
            btnRestar.Tag = "−";
            btnRestar.Text = "−";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += clickOperador;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = System.Drawing.Color.Blue;
            btnSumar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSumar.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSumar.Location = new System.Drawing.Point(187, 190);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new System.Drawing.Size(45, 45);
            btnSumar.TabIndex = 17;
            btnSumar.Tag = "+";
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += clickOperador;
            // 
            // btnResultado
            // 
            btnResultado.BackColor = System.Drawing.Color.Blue;
            btnResultado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnResultado.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnResultado.Location = new System.Drawing.Point(187, 249);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new System.Drawing.Size(102, 45);
            btnResultado.TabIndex = 19;
            btnResultado.Text = "=";
            btnResultado.UseVisualStyleBackColor = false;
            btnResultado.Click += btnResultado_Click;
            // 
            // btnPunto
            // 
            btnPunto.BackColor = System.Drawing.Color.GhostWhite;
            btnPunto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnPunto.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnPunto.Location = new System.Drawing.Point(127, 310);
            btnPunto.Name = "btnPunto";
            btnPunto.Size = new System.Drawing.Size(45, 45);
            btnPunto.TabIndex = 22;
            btnPunto.Text = ".";
            btnPunto.UseVisualStyleBackColor = false;
            btnPunto.Click += btnPunto_Click;
            // 
            // btnCero
            // 
            btnCero.BackColor = System.Drawing.Color.GhostWhite;
            btnCero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCero.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCero.Location = new System.Drawing.Point(70, 310);
            btnCero.Name = "btnCero";
            btnCero.Size = new System.Drawing.Size(45, 45);
            btnCero.TabIndex = 21;
            btnCero.Text = "0";
            btnCero.UseVisualStyleBackColor = false;
            btnCero.Click += agregarNumero;
            // 
            // btnSigno
            // 
            btnSigno.BackColor = System.Drawing.Color.GhostWhite;
            btnSigno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnSigno.Font = new System.Drawing.Font("Goudy Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSigno.Location = new System.Drawing.Point(13, 310);
            btnSigno.Name = "btnSigno";
            btnSigno.Size = new System.Drawing.Size(45, 45);
            btnSigno.TabIndex = 20;
            btnSigno.Text = "+/-";
            btnSigno.UseVisualStyleBackColor = false;
            btnSigno.Click += btnSigno_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(306, 365);
            Controls.Add(btnPunto);
            Controls.Add(btnCero);
            Controls.Add(btnSigno);
            Controls.Add(btnResultado);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnCuadrado);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btnQuitar);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnBorrar);
            Controls.Add(btnNueve);
            Controls.Add(btnOcho);
            Controls.Add(btnSiete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnCuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDos);
            Controls.Add(btnUno);
            Controls.Add(txtResultado);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Calculadora de Fredo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnUno;
        private System.Windows.Forms.Button btnDos;
        private System.Windows.Forms.Button btnTres;
        private System.Windows.Forms.Button btnSeis;
        private System.Windows.Forms.Button btnCinco;
        private System.Windows.Forms.Button btnCuatro;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnNueve;
        private System.Windows.Forms.Button btnOcho;
        private System.Windows.Forms.Button btnSiete;
        private System.Windows.Forms.Button btnCuadrado;
        private System.Windows.Forms.Button btnRaizCuadrada;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnPunto;
        private System.Windows.Forms.Button btnCero;
        private System.Windows.Forms.Button btnSigno;
    }
}

