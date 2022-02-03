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
        private DataSet das1,dasComboBox;
        private SqlDataAdapter adap1,adapComboBox;

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

            das1.Tables[0].PrimaryKey = new DataColumn[] { das1.Tables[0].Columns["CodVend"] };

            SqlCommandBuilder cmb = new SqlCommandBuilder(adap1); //NUEVO
            //Para que me cree las sentencias UPDATE, DELETE, INSERT
            //MessageBox.Show(cmb.GetInsertCommand().CommandText);
            //Lo que genera el cmb lo utiliza el adap1.Update(das1, "aaa");

            ///////////////////////////////////
            //Para el ComboBox del ejercicio 21
            dasComboBox = new DataSet();
            try
            {
                cmd1 = new SqlCommand("Select distinct CodCli from Clientes order by CodCli", Conexion.pConexion);
                adapComboBox = new SqlDataAdapter(cmd1);
                adapComboBox.Fill(dasComboBox, "aaa");
                //'Relleno con vinculación compleja  // NO HE CONSEGUIDO COGER EL VALOR
                //ComboBox1.DataSource = das1.Tables[0];
                //ComboBox1.DisplayMember = "OrderId";

                //'Otro modo es utilizando un For 
                for (int x = 0; x <= dasComboBox.Tables[0].Rows.Count - 1; x = x + 1)
                {
                    ComboBoxCodCli.Items.Add(dasComboBox.Tables[0].Rows[x][0]);
                }
                //ComboBox1.Sorted = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void buttonBorrarDataSet_Click(object sender, EventArgs e)
        {
            //BORRAR DATASET
            das1.Tables[0].Clear();
        }

        private void buttonBorrarClavePrimaria_Click(object sender, EventArgs e)
        {

            das1.Tables[0].Rows.Find(txtBorrar.Text).Delete();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFila.Text = Convert.ToString(DataGridView1.CurrentRow.Cells[1].Value);
            //'Por si la celda está vacia...
            if (!Convert.IsDBNull(this.DataGridView1.CurrentRow.Cells[6].Value))
            {
                txtFila1.Text = Convert.ToString(DataGridView1.CurrentRow.Cells[6].Value);
            }
            else
            {
                txtFila1.Text = "";
            }
        }

        private void buttonIrFila_Click(object sender, EventArgs e)
        {
            //ir a una fila
            int fila = Convert.ToInt32(this.txtIrFila.Text);
            fila = fila - 1;
            if (fila >= 0 && fila < das1.Tables[0].Rows.Count)
            {
                this.DataGridView1.Rows[fila].Selected = true;
                this.DataGridView1.CurrentCell = this.DataGridView1.Rows[fila].Cells[0];
                // para llenar los textboxes
                txtFila.Text = Convert.ToString(DataGridView1.CurrentRow.Cells[1].Value);
                //'Por si la celda está vacia...
                if (!Convert.IsDBNull(this.DataGridView1.CurrentRow.Cells[6].Value))
                {
                    txtFila1.Text = Convert.ToString(DataGridView1.CurrentRow.Cells[6].Value);
                }
                else
                {
                    txtFila1.Text = "";
                }
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //buscar
            //Buscar por NombVen
            string aaa;
            string bbb;
            // En Referencias, Agregar referencia, Microsoft.VisualBasic
            aaa = Interaction.InputBox("Introduce el NombVen", "Buscar", "NURIA NUÑEZ JURADO");
            for (int x = 0; x <= das1.Tables[0].Rows.Count - 1; x = x + 1)
            {
                bbb = Convert.ToString(das1.Tables[0].Rows[x][1]);
                if (bbb.StartsWith(aaa))
                {
                    DataGridView1.Rows[x].Selected = true;
                    DataGridView1.CurrentCell = DataGridView1[0, x];
                    MessageBox.Show("ENCONTRADO");
                }
            }
        }

        private void ComboBoxCodCli_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
