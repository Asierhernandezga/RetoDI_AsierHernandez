using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient; //añadido
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; //añadido

namespace DI_RetoCS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // NO CONECTADO (Tiene DATASET Y SQLDATAADAPTER)
        private string sql;
        private MiConexion Conexion = new MiConexion();
        private DataSet das1;
        private SqlDataAdapter adap1;

        private void button1_Click(object sender, EventArgs e)
        {
            Padre.f1.Activate();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sql = "select * from Vendedores";
            SqlCommand cmd1 = new SqlCommand(sql, Conexion.pConexion);
            adap1 = new SqlDataAdapter(cmd1);
            das1 = new DataSet();
            adap1.Fill(das1, "aaa");
            DataGridView1.DataSource = das1.Tables[0];
            DataGridView1.Columns[0].Width = 60;
            DataGridView1.Columns[1].Width = 160;
            DataGridView1.Columns[2].Width = 80;
            DataGridView1.Columns[3].Width = 100;
            DataGridView1.Columns[4].Width = 100;
            DataGridView1.Columns[5].Width = 100;
            DataGridView1.Columns[6].Width = 60;
            DataGridView1.Columns[7].Width = 60;
            DataGridView1.Columns[8].Width = 60;

            SqlCommandBuilder cmb = new SqlCommandBuilder(adap1); //NUEVO
            //Para que me cree las sentencias UPDATE, DELETE, INSERT
            //MessageBox.Show(cmb.GetInsertCommand().CommandText);
            //Lo que genera el cmb lo utiliza el adap1.Update(das1, "aaa");
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            das1.Tables[0].Clear();
            adap1.Fill(das1, "aaa");
            lblFilasInsertadas.Text = das1.Tables[0].Rows.Count + " filas.";
        }

        private void buttonGuardarXML_Click(object sender, EventArgs e)
        {
            //GUARDAR XML
            das1.WriteXml("bbb.xml"); // se guarda en el \bin\debug
            das1.WriteXmlSchema("ccc.xml");
        }

        private void buttonLeerXML_Click(object sender, EventArgs e)
        {
            //leer XML
            das1.Tables[0].Clear();
            das1.ReadXml("bbb.xml"); //en el \bin\debug
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                adap1.Update(das1, "aaa");//ACTUALIZA LA BD
                //PRIMERO HAY QUE PONER EL COMMANDBUILDER.
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
        }

        private void buttonAñadirX_Click(object sender, EventArgs e)
        {
            //añadir x
            das1.Tables[0].Rows[0][3] += "X";
        }

        private void buttonQuitarUltimo_Click(object sender, EventArgs e)
        {
            //quitar el último caracter
            string aaa = Convert.ToString(das1.Tables[0].Rows[0][3]);
            das1.Tables[0].Rows[0][3] = aaa.Substring(0, aaa.Length - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonBorrarDataSet_Click(object sender, EventArgs e)
        {
            //BORRAR DATASET
            das1.Tables[0].Clear();
        }
    }
}
