﻿
namespace DI_RetoCS
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblNoConectado = new System.Windows.Forms.Label();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblFacturas = new System.Windows.Forms.Label();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.lblFilasInsertadas = new System.Windows.Forms.Label();
            this.buttonGuardarXML = new System.Windows.Forms.Button();
            this.buttonLeerXML = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAñadirX = new System.Windows.Forms.Button();
            this.buttonQuitarUltimo = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.buttonBorrarDataSet = new System.Windows.Forms.Button();
            this.buttonBorrarClavePrimaria = new System.Windows.Forms.Button();
            this.txtBorrar = new System.Windows.Forms.TextBox();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.txtFila1 = new System.Windows.Forms.TextBox();
            this.txtIrFila = new System.Windows.Forms.TextBox();
            this.buttonIrFila = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.ComboBoxCodCli = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ir al Form1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNoConectado
            // 
            this.lblNoConectado.AutoSize = true;
            this.lblNoConectado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoConectado.Location = new System.Drawing.Point(12, 15);
            this.lblNoConectado.Name = "lblNoConectado";
            this.lblNoConectado.Size = new System.Drawing.Size(123, 20);
            this.lblNoConectado.TabIndex = 1;
            this.lblNoConectado.Text = "No Conectado";
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(16, 73);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(772, 168);
            this.DataGridView1.TabIndex = 2;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // lblFacturas
            // 
            this.lblFacturas.AutoSize = true;
            this.lblFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturas.Location = new System.Drawing.Point(13, 44);
            this.lblFacturas.Name = "lblFacturas";
            this.lblFacturas.Size = new System.Drawing.Size(99, 16);
            this.lblFacturas.TabIndex = 3;
            this.lblFacturas.Text = "Tabla Facturas";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(154, 31);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(61, 29);
            this.buttonCargar.TabIndex = 22;
            this.buttonCargar.Text = "CARGAR";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // lblFilasInsertadas
            // 
            this.lblFilasInsertadas.AutoSize = true;
            this.lblFilasInsertadas.Location = new System.Drawing.Point(221, 39);
            this.lblFilasInsertadas.Name = "lblFilasInsertadas";
            this.lblFilasInsertadas.Size = new System.Drawing.Size(87, 13);
            this.lblFilasInsertadas.TabIndex = 23;
            this.lblFilasInsertadas.Text = "lblFilasInsertadas";
            // 
            // buttonGuardarXML
            // 
            this.buttonGuardarXML.Location = new System.Drawing.Point(16, 256);
            this.buttonGuardarXML.Name = "buttonGuardarXML";
            this.buttonGuardarXML.Size = new System.Drawing.Size(75, 36);
            this.buttonGuardarXML.TabIndex = 26;
            this.buttonGuardarXML.Text = "GUARDAR XML";
            this.buttonGuardarXML.UseVisualStyleBackColor = true;
            this.buttonGuardarXML.Click += new System.EventHandler(this.buttonGuardarXML_Click);
            // 
            // buttonLeerXML
            // 
            this.buttonLeerXML.Location = new System.Drawing.Point(97, 256);
            this.buttonLeerXML.Name = "buttonLeerXML";
            this.buttonLeerXML.Size = new System.Drawing.Size(75, 36);
            this.buttonLeerXML.TabIndex = 28;
            this.buttonLeerXML.Text = "LEER XML";
            this.buttonLeerXML.UseVisualStyleBackColor = true;
            this.buttonLeerXML.Click += new System.EventHandler(this.buttonLeerXML_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(178, 256);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 36);
            this.buttonUpdate.TabIndex = 29;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAñadirX
            // 
            this.buttonAñadirX.Location = new System.Drawing.Point(259, 256);
            this.buttonAñadirX.Name = "buttonAñadirX";
            this.buttonAñadirX.Size = new System.Drawing.Size(75, 36);
            this.buttonAñadirX.TabIndex = 30;
            this.buttonAñadirX.Text = "Añadir X";
            this.buttonAñadirX.UseVisualStyleBackColor = true;
            this.buttonAñadirX.Click += new System.EventHandler(this.buttonAñadirX_Click);
            // 
            // buttonQuitarUltimo
            // 
            this.buttonQuitarUltimo.Location = new System.Drawing.Point(340, 256);
            this.buttonQuitarUltimo.Name = "buttonQuitarUltimo";
            this.buttonQuitarUltimo.Size = new System.Drawing.Size(75, 36);
            this.buttonQuitarUltimo.TabIndex = 31;
            this.buttonQuitarUltimo.Text = "Quitar X";
            this.buttonQuitarUltimo.UseVisualStyleBackColor = true;
            this.buttonQuitarUltimo.Click += new System.EventHandler(this.buttonQuitarUltimo_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(323, 34);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(454, 20);
            this.Label1.TabIndex = 32;
            this.Label1.Text = "Con Dataset/OleDbDataAdapter/OLEDBCOMMANDBUILDER";
            // 
            // buttonBorrarDataSet
            // 
            this.buttonBorrarDataSet.Location = new System.Drawing.Point(421, 256);
            this.buttonBorrarDataSet.Name = "buttonBorrarDataSet";
            this.buttonBorrarDataSet.Size = new System.Drawing.Size(75, 36);
            this.buttonBorrarDataSet.TabIndex = 33;
            this.buttonBorrarDataSet.Text = "Borrar DATASET";
            this.buttonBorrarDataSet.UseVisualStyleBackColor = true;
            this.buttonBorrarDataSet.Click += new System.EventHandler(this.buttonBorrarDataSet_Click);
            // 
            // buttonBorrarClavePrimaria
            // 
            this.buttonBorrarClavePrimaria.Location = new System.Drawing.Point(502, 256);
            this.buttonBorrarClavePrimaria.Name = "buttonBorrarClavePrimaria";
            this.buttonBorrarClavePrimaria.Size = new System.Drawing.Size(80, 36);
            this.buttonBorrarClavePrimaria.TabIndex = 34;
            this.buttonBorrarClavePrimaria.Text = "Borrar CLAVE PRIMARIA";
            this.buttonBorrarClavePrimaria.UseVisualStyleBackColor = true;
            this.buttonBorrarClavePrimaria.Click += new System.EventHandler(this.buttonBorrarClavePrimaria_Click);
            // 
            // txtBorrar
            // 
            this.txtBorrar.Location = new System.Drawing.Point(588, 265);
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(100, 20);
            this.txtBorrar.TabIndex = 35;
            // 
            // txtFila
            // 
            this.txtFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFila.Location = new System.Drawing.Point(16, 311);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(228, 26);
            this.txtFila.TabIndex = 36;
            // 
            // txtFila1
            // 
            this.txtFila1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFila1.Location = new System.Drawing.Point(16, 343);
            this.txtFila1.Name = "txtFila1";
            this.txtFila1.Size = new System.Drawing.Size(228, 26);
            this.txtFila1.TabIndex = 37;
            // 
            // txtIrFila
            // 
            this.txtIrFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIrFila.Location = new System.Drawing.Point(391, 320);
            this.txtIrFila.Name = "txtIrFila";
            this.txtIrFila.Size = new System.Drawing.Size(52, 26);
            this.txtIrFila.TabIndex = 39;
            // 
            // buttonIrFila
            // 
            this.buttonIrFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIrFila.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonIrFila.Location = new System.Drawing.Point(285, 311);
            this.buttonIrFila.Name = "buttonIrFila";
            this.buttonIrFila.Size = new System.Drawing.Size(100, 43);
            this.buttonIrFila.TabIndex = 38;
            this.buttonIrFila.Text = "Ir a la fila:";
            this.buttonIrFila.UseVisualStyleBackColor = true;
            this.buttonIrFila.Click += new System.EventHandler(this.buttonIrFila_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonBuscar.Location = new System.Drawing.Point(502, 311);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 43);
            this.buttonBuscar.TabIndex = 40;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // ComboBoxCodCli
            // 
            this.ComboBoxCodCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxCodCli.FormattingEnabled = true;
            this.ComboBoxCodCli.Location = new System.Drawing.Point(502, 396);
            this.ComboBoxCodCli.Name = "ComboBoxCodCli";
            this.ComboBoxCodCli.Size = new System.Drawing.Size(151, 32);
            this.ComboBoxCodCli.TabIndex = 41;
            this.ComboBoxCodCli.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCodCli_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboBoxCodCli);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.txtIrFila);
            this.Controls.Add(this.buttonIrFila);
            this.Controls.Add(this.txtFila1);
            this.Controls.Add(this.txtFila);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.buttonBorrarClavePrimaria);
            this.Controls.Add(this.buttonBorrarDataSet);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonQuitarUltimo);
            this.Controls.Add(this.buttonAñadirX);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonLeerXML);
            this.Controls.Add(this.buttonGuardarXML);
            this.Controls.Add(this.lblFilasInsertadas);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.lblFacturas);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.lblNoConectado);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNoConectado;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label lblFacturas;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label lblFilasInsertadas;
        private System.Windows.Forms.Button buttonGuardarXML;
        private System.Windows.Forms.Button buttonLeerXML;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAñadirX;
        private System.Windows.Forms.Button buttonQuitarUltimo;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button buttonBorrarDataSet;
        private System.Windows.Forms.Button buttonBorrarClavePrimaria;
        private System.Windows.Forms.TextBox txtBorrar;
        internal System.Windows.Forms.TextBox txtFila;
        internal System.Windows.Forms.TextBox txtFila1;
        internal System.Windows.Forms.TextBox txtIrFila;
        internal System.Windows.Forms.Button buttonIrFila;
        internal System.Windows.Forms.Button buttonBuscar;
        internal System.Windows.Forms.ComboBox ComboBoxCodCli;
    }
}