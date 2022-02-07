
namespace DI_RetoCS
{
    partial class Padre
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miLista = new System.Windows.Forms.ToolStripMenuItem();
            this.DataSet1 = new DI_RetoCS.DataSet1();
            this.PeliculasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PeliculasTableAdapter = new DI_RetoCS.DataSet1TableAdapters.PeliculasTableAdapter();
            this.form1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulariosToolStripMenuItem,
            this.miLista});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulariosToolStripMenuItem
            // 
            this.formulariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form1ToolStripMenuItem1,
            this.form2ToolStripMenuItem,
            this.form1ToolStripMenuItem,
            this.form4ToolStripMenuItem,
            this.form5ToolStripMenuItem});
            this.formulariosToolStripMenuItem.Name = "formulariosToolStripMenuItem";
            this.formulariosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.formulariosToolStripMenuItem.Text = "Formularios";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form2ToolStripMenuItem.Text = "Form2";
            this.form2ToolStripMenuItem.Click += new System.EventHandler(this.form2ToolStripMenuItem_Click);
            // 
            // form1ToolStripMenuItem
            // 
            this.form1ToolStripMenuItem.Name = "form1ToolStripMenuItem";
            this.form1ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.form1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form1ToolStripMenuItem.Text = "Form3";
            this.form1ToolStripMenuItem.Click += new System.EventHandler(this.form1ToolStripMenuItem_Click);
            // 
            // form4ToolStripMenuItem
            // 
            this.form4ToolStripMenuItem.Name = "form4ToolStripMenuItem";
            this.form4ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.form4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form4ToolStripMenuItem.Text = "Form4";
            this.form4ToolStripMenuItem.Click += new System.EventHandler(this.form4ToolStripMenuItem_Click);
            // 
            // form5ToolStripMenuItem
            // 
            this.form5ToolStripMenuItem.Name = "form5ToolStripMenuItem";
            this.form5ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.form5ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.form5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form5ToolStripMenuItem.Text = "Form5";
            this.form5ToolStripMenuItem.Click += new System.EventHandler(this.form5ToolStripMenuItem_Click);
            // 
            // miLista
            // 
            this.miLista.Name = "miLista";
            this.miLista.Size = new System.Drawing.Size(94, 20);
            this.miLista.Text = "Form Abiertos";
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PeliculasBindingSource
            // 
            this.PeliculasBindingSource.DataMember = "Peliculas";
            this.PeliculasBindingSource.DataSource = this.DataSet1;
            // 
            // PeliculasTableAdapter
            // 
            this.PeliculasTableAdapter.ClearBeforeFill = true;
            // 
            // form1ToolStripMenuItem1
            // 
            this.form1ToolStripMenuItem1.Name = "form1ToolStripMenuItem1";
            this.form1ToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.form1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.form1ToolStripMenuItem1.Text = "Form1";
            this.form1ToolStripMenuItem1.Click += new System.EventHandler(this.form1ToolStripMenuItem1_Click);
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 567);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Padre";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Padre_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeliculasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLista;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form5ToolStripMenuItem;
        private System.Windows.Forms.BindingSource PeliculasBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.PeliculasTableAdapter PeliculasTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem form1ToolStripMenuItem1;
    }
}

