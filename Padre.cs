using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_RetoCS
{
    public partial class Padre : Form
    {
        public Padre()
        {
            InitializeComponent();
        }
        public static Form1 f1 = new Form1();
        // Para que lo veamos en los demas formularios
        private Form2 f2 = new Form2();
        private Form3 f3 = new Form3();
        private Form4 f4 = new Form4();
        private Form5 f5 = new Form5();
        private void Padre_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Peliculas' Puede moverla o quitarla según sea necesario.
            this.PeliculasTableAdapter.Fill(this.DataSet1.Peliculas);
            this.IsMdiContainer = true;
            this.menuStrip1.MdiWindowListItem = miLista;
            f1.MdiParent = this;
            f2.MdiParent = this;
            f3.MdiParent = this;
            f4.MdiParent = this;
            f5.MdiParent = this;
            f1.WindowState = FormWindowState.Maximized;
            f2.WindowState = FormWindowState.Maximized;
            f3.WindowState = FormWindowState.Maximized;
            f4.WindowState = FormWindowState.Maximized;
            f5.WindowState = FormWindowState.Maximized;
            f1.Show();
            f1.Activate();
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2.Show();
            f2.Activate();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3.Show();
            f3.Activate();
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f4.Show();
            f4.Activate();
        }

        private void form5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.Show();
            f5.Activate();
        }

        private void form1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f1.Show();
            f1.Activate();
        }
    }
}
