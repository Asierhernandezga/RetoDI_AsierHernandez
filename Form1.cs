using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //añadido

namespace DI_RetoCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string sql;
        private int cont;
        private MiConexion Conexion = new MiConexion();
        private int result;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPais.SelectedIndex = 0;
        }

        private void buttonContarSinParametros_Click(object sender, EventArgs e)
        {
            //02-Contar
            sql = "Select count(*) from Peliculas";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                MessageBox.Show("Hay: " + result);
                textBoxResultadoContar.Text = ""+result;
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void buttonContarConParametros_Click(object sender, EventArgs e)
        {
            //METADATOS


            string ComboText = comboBoxPais.Text;   //Para coger el texto del ComboBox

            sql = "Select count(*) from Peliculas where Pais ='" + ComboText+ "'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                result = Convert.ToInt32(cmd.ExecuteScalar());
                MessageBox.Show("Hay: " + result);
                textBoxResultadoContar.Text = "" + result;
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void buttonInsertarSinParametros_Click(object sender, EventArgs e)
        {
            //Insertar
            sql = "Insert into Peliculas (CodPelicula,Titulo,Duración,CodGenero,Año,Productora,Pais,Precio,Director) ";
            sql += "values ('999','Elorrieta','120','1','2022','A','España','2','Yo')";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Insertadas: " + result + " filas.");
                textBoxResultadoInsertar.Text = "" + result;
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void buttonInsertarConParametros_Click(object sender, EventArgs e)
        {
            //Insertar
            sql = "Insert into Peliculas (CodPelicula,Titulo,Duración,CodGenero,Año,Productora,Pais,Precio,Director) ";
            sql += "values ('999','Elorrieta','120','1','2022','A','España','2','Yo')";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Insertadas: " + result + " filas.");
                textBoxResultadoInsertar.Text = "" + result;
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void buttonUpdateSinParametros_Click(object sender, EventArgs e)
        {
            //UPDATE
            sql = "update Peliculas set Director='Tu'";
            sql += "where Director='Yo'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Actualizadas: " + result + " filas.");
                textBoxResultadoUpdate.Text = "" + result;
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void buttonUpdateConParametros_Click(object sender, EventArgs e)
        {
            //UPDATE
            sql = "update Peliculas set Director='Tu' ";
            sql += "where Director='Yo'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Actualizadas: " + result + " filas.");
                textBoxResultadoUpdate.Text = "" + result;
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Delete
            sql = "Delete from Peliculas where Director='Tu'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Borradas: " + result + " filas.");
                textBoxResultadoDelete.Text = "" + result;
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void buttonDeleteConParametros_Click(object sender, EventArgs e)
        {
            //Delete
            sql = "Delete from Peliculas where Director='Tu'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                result = Convert.ToInt32(cmd.ExecuteNonQuery());
                MessageBox.Show("Borradas: " + result + " filas.");
                textBoxResultadoDelete.Text = "" + result;
                Conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void buttonListView_Click(object sender, EventArgs e)
        {
            //LEER



            string ComboText = comboBoxGenero.Text;   //Para coger el texto del ComboBox

            sql = "Select Titulo from Peliculas where CodGenero ='" + ComboText + "'";

            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                SqlDataReader dr = null; //NO tiene NEW
                dr = cmd.ExecuteReader();
                listView1.Clear();
                listView1.GridLines = true;
                listView1.View = View.Details;
                //añadimnos las columnas al listview1
                listView1.Columns.Add("Nombre", 120, HorizontalAlignment.Right);
                listView1.Columns.Add(dr.GetName(1), 160, HorizontalAlignment.Right);
                listView1.Columns.Add(dr.GetName(2), 120, HorizontalAlignment.Right);
                listView1.Columns.Add(dr.GetName(3), 120, HorizontalAlignment.Right);

                while (dr.Read())
                {
                    ListViewItem fila = new ListViewItem(dr.GetString(0));
                    fila.SubItems.Add(dr.GetString(1));
                    fila.SubItems.Add(dr.GetString(2));
                    fila.SubItems.Add(dr.GetString(3));
                    listView1.Items.Add(fila);
                }

                Conexion.CerrarConexion();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }
    }
}
