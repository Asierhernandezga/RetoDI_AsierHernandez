
namespace DI_RetoCS
{
    partial class Form1
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
            this.lblConectado = new System.Windows.Forms.Label();
            this.lblConParametros = new System.Windows.Forms.Label();
            this.lblSinParametros = new System.Windows.Forms.Label();
            this.lblContar = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.textBoxResultadoContar = new System.Windows.Forms.TextBox();
            this.buttonContarSinParametros = new System.Windows.Forms.Button();
            this.buttonContarConParametros = new System.Windows.Forms.Button();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConectado
            // 
            this.lblConectado.AutoSize = true;
            this.lblConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConectado.Location = new System.Drawing.Point(13, 13);
            this.lblConectado.Name = "lblConectado";
            this.lblConectado.Size = new System.Drawing.Size(96, 20);
            this.lblConectado.TabIndex = 0;
            this.lblConectado.Text = "Conectado";
            // 
            // lblConParametros
            // 
            this.lblConParametros.AutoSize = true;
            this.lblConParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConParametros.Location = new System.Drawing.Point(143, 81);
            this.lblConParametros.Name = "lblConParametros";
            this.lblConParametros.Size = new System.Drawing.Size(105, 16);
            this.lblConParametros.TabIndex = 1;
            this.lblConParametros.Text = "Con Parametros";
            // 
            // lblSinParametros
            // 
            this.lblSinParametros.AutoSize = true;
            this.lblSinParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinParametros.Location = new System.Drawing.Point(14, 81);
            this.lblSinParametros.Name = "lblSinParametros";
            this.lblSinParametros.Size = new System.Drawing.Size(100, 16);
            this.lblSinParametros.TabIndex = 2;
            this.lblSinParametros.Text = "Sin Parametros";
            // 
            // lblContar
            // 
            this.lblContar.AutoSize = true;
            this.lblContar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContar.Location = new System.Drawing.Point(14, 46);
            this.lblContar.Name = "lblContar";
            this.lblContar.Size = new System.Drawing.Size(53, 16);
            this.lblContar.TabIndex = 3;
            this.lblContar.Text = "Contar";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(282, 81);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(70, 16);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // textBoxResultadoContar
            // 
            this.textBoxResultadoContar.Location = new System.Drawing.Point(285, 111);
            this.textBoxResultadoContar.Name = "textBoxResultadoContar";
            this.textBoxResultadoContar.Size = new System.Drawing.Size(100, 20);
            this.textBoxResultadoContar.TabIndex = 5;
            // 
            // buttonContarSinParametros
            // 
            this.buttonContarSinParametros.Location = new System.Drawing.Point(17, 108);
            this.buttonContarSinParametros.Name = "buttonContarSinParametros";
            this.buttonContarSinParametros.Size = new System.Drawing.Size(97, 23);
            this.buttonContarSinParametros.TabIndex = 6;
            this.buttonContarSinParametros.Text = "Sin Parametros";
            this.buttonContarSinParametros.UseVisualStyleBackColor = true;
            this.buttonContarSinParametros.Click += new System.EventHandler(this.buttonContarSinParametros_Click);
            // 
            // buttonContarConParametros
            // 
            this.buttonContarConParametros.Location = new System.Drawing.Point(146, 109);
            this.buttonContarConParametros.Name = "buttonContarConParametros";
            this.buttonContarConParametros.Size = new System.Drawing.Size(97, 23);
            this.buttonContarConParametros.TabIndex = 7;
            this.buttonContarConParametros.Text = "Con Parametros";
            this.buttonContarConParametros.UseVisualStyleBackColor = true;
            this.buttonContarConParametros.Click += new System.EventHandler(this.buttonContarConParametros_Click);
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Items.AddRange(new object[] {
            "ALEMANIA",
            "ALGUNO",
            "ARGENTINA",
            "AUSTRALIA",
            "CANADA",
            "EE.UU",
            "ESPAÑA",
            "FRANCIA",
            "JAPON",
            "PRUEBA",
            "PRUEBA2",
            "U.K"});
            this.comboBoxPais.Location = new System.Drawing.Point(146, 46);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPais.TabIndex = 8;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.Location = new System.Drawing.Point(184, 17);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(35, 16);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "Pais";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.comboBoxPais);
            this.Controls.Add(this.buttonContarConParametros);
            this.Controls.Add(this.buttonContarSinParametros);
            this.Controls.Add(this.textBoxResultadoContar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblContar);
            this.Controls.Add(this.lblSinParametros);
            this.Controls.Add(this.lblConParametros);
            this.Controls.Add(this.lblConectado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConectado;
        private System.Windows.Forms.Label lblConParametros;
        private System.Windows.Forms.Label lblSinParametros;
        private System.Windows.Forms.Label lblContar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox textBoxResultadoContar;
        private System.Windows.Forms.Button buttonContarSinParametros;
        private System.Windows.Forms.Button buttonContarConParametros;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Label lblPais;
    }
}