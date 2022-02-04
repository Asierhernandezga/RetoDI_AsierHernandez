using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI_RetoCS
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private MiConexion Conexion = new MiConexion();
        DataSet das1 = new DataSet();
        SqlDataAdapter adaporders;
        SqlDataAdapter adapdetails;
        private void button1_Click(object sender, EventArgs e)
        {
            Padre.f1.Activate();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                string sql2 = "select * from Clientes";
                string sql1 = "select * from Facturas";
                //'Hay un solo das1 y dos adaptadores
                adaporders = new SqlDataAdapter(sql2, Conexion.pConexion);
                adaporders.Fill(das1, "padre");
                adapdetails = new SqlDataAdapter(sql1, Conexion.pConexion);
                adapdetails.Fill(das1, "hijo");

                //'Creo la relacion en el das1 
                DataColumn a, b;
                a = das1.Tables["padre"].Columns["CodCli"];
                b = das1.Tables["hijo"].Columns["CodCli"];
                das1.Relations.Add("mirelacion", a, b);
                //'visualizamos
                DataGridView1.DataSource = das1;
                DataGridView1.DataMember = "padre";
                DataGridView2.DataSource = das1;
                DataGridView2.DataMember = "padre.mirelacion";

                //'crear automaticamente la sql para update -
                SqlCommandBuilder cmb1 = new SqlCommandBuilder(adaporders);
                SqlCommandBuilder cmb2 = new SqlCommandBuilder(adapdetails);

                Label4.Text = Convert.ToString(das1.Tables["padre"].Rows.Count - 1) + " filas.";
                Label5.Text = Convert.ToString(DataGridView2.Rows.Count - 1) + " filas.";

                das1.Tables[0].PrimaryKey = new DataColumn[] { das1.Tables[0].Columns["CodCli"] };

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //'update
            adaporders.Update(das1, "padre");
            adapdetails.Update(das1, "hijo");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //'Creo una clave primaria para poder utilizar el FIND 
            das1.Tables["padre"].PrimaryKey = new DataColumn[] { das1.Tables["padre"].Columns["orderid"] };
            int aaa = 0;
            // AGREGO LA REFERENCIA MICROSOFT.VISUALBASIC
            aaa = Convert.ToInt32(Interaction.InputBox("Escribe el CodCli", "Busqueda por CodCli", "102"));
            DataRow drw = das1.Tables["padre"].Rows.Find(aaa);
            MessageBox.Show(drw.ItemArray[1].ToString());
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Label5.Text = Convert.ToString(DataGridView2.Rows.Count - 1) + " filas.";
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            int aaa = 0;
            aaa = Convert.ToInt32(Interaction.InputBox("Escribe el CodCli", "Borrar por CodCli", "102"));
            das1.Tables[0].Rows.Find(aaa).Delete();
        }
    }
}
