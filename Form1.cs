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
            comboBoxFechaComparar.SelectedIndex = 0;
            comboBoxFechaComparar1.SelectedIndex = 0;
            comboBoxGenero.SelectedIndex = 0;
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

            sql = "Select Titulo from Peliculas where CodGenero =" + ComboText;

            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                SqlDataReader dr = null; //NO tiene NEW
                dr = cmd.ExecuteReader();
                listViewPeliculas.Clear();
                listViewPeliculas.GridLines = true;
                listViewPeliculas.View = View.Details;
                //añadimnos las columnas al listview1
                listViewPeliculas.Columns.Add(dr.GetName(0), 160, HorizontalAlignment.Right);

                while (dr.Read())
                {
                    ListViewItem fila = new ListViewItem(dr.GetString(0));
                    //fila.SubItems.Add(dr.GetString(0));
                    listViewPeliculas.Items.Add(fila);
                }

                Conexion.CerrarConexion();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void buttonListView1_Click(object sender, EventArgs e)
        {

            sql = "Select * from Facturas where Fecha >='" + comboBoxFechaComparar.Text + "'and Fecha <='"+ comboBoxFechaComparar1.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            try
            {
                Conexion.AbrirConexion();
                SqlDataReader dr = null; //NO tiene NEW
                dr = cmd.ExecuteReader();
                listViewFacturas.Clear();
                listViewFacturas.GridLines = true;
                listViewFacturas.View = View.Details;
                //añadimnos las columnas al listview1
                listViewFacturas.Columns.Add(dr.GetName(0), 160, HorizontalAlignment.Right);
                listViewFacturas.Columns.Add(dr.GetName(1), 160, HorizontalAlignment.Right);
                listViewFacturas.Columns.Add(dr.GetName(2), 160, HorizontalAlignment.Right);
                listViewFacturas.Columns.Add(dr.GetName(3), 160, HorizontalAlignment.Right);
                listViewFacturas.Columns.Add(dr.GetName(4), 160, HorizontalAlignment.Right);
                listViewFacturas.Columns.Add(dr.GetName(5), 160, HorizontalAlignment.Right);
                listViewFacturas.Columns.Add(dr.GetName(6), 160, HorizontalAlignment.Right);
                listViewFacturas.Columns.Add(dr.GetName(7), 160, HorizontalAlignment.Right);
                listViewFacturas.Columns.Add(dr.GetName(8), 160, HorizontalAlignment.Right);

                while (dr.Read())
                {
                    ListViewItem fila = new ListViewItem(Convert.ToString(dr.GetValue(0)));
                    //fila.SubItems.Add(Convert.ToString(dr.GetDateTime(1).ToShortDateString()));
                    fila.SubItems.Add(Convert.ToString(dr.GetValue(1)));
                    fila.SubItems.Add(Convert.ToString(dr.GetValue(2)));
                    fila.SubItems.Add(Convert.ToString(dr.GetValue(3)));
                    fila.SubItems.Add(Convert.ToString(dr.GetValue(4)));
                    fila.SubItems.Add(Convert.ToString(dr.GetValue(5)));
                    fila.SubItems.Add(Convert.ToString(dr.GetValue(6)));
                    fila.SubItems.Add(Convert.ToString(dr.GetValue(7)));
                    fila.SubItems.Add(Convert.ToString(dr.GetValue(8)));
                    listViewFacturas.Items.Add(fila);
                }

                Conexion.CerrarConexion();
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());

            }
        }

        private void buttonMetadatosFactura_Click(object sender, EventArgs e)
        {
            //METADATOS
            sql = "Select * from Facturas";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            string acum = null;
            SqlDataReader dr;
            cont = 0;
            try
            {
                Conexion.AbrirConexion();
                dr = cmd.ExecuteReader();
                for (int x = 0; x <= dr.FieldCount - 1; x++)
                {
                    acum += dr.GetName(x) + " - " + dr.GetFieldType(x) + Environment.NewLine;
                }
                acum += new string('-', 30);  // en c# no existe strdup
                MessageBox.Show(acum);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }

        private void buttonMsgBox25Clientes_Click(object sender, EventArgs e)
        {
            string acum = null;
            sql = "Select * from Clientes";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            SqlDataReader dr;
            cont = 0;
            try
            {
                Conexion.AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cont += 1;
                    //acum += cont + "- " + dr.GetValue(0) + "- " + dr.GetString(1) + "- " + dr.GetString(2) + "- " + dr.GetValue(3) + "- " + dr.GetValue(4) + Environment.NewLine;
                    acum += cont + "- " + dr.GetValue(0) + "- " + dr.GetString(1) + "- " + Environment.NewLine;
                    if ((cont % 25) == 0)
                    {
                        MessageBox.Show(acum);
                        acum = null;
                    }
                }
                if (acum != null)
                {
                    MessageBox.Show(acum);
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Conexion.CerrarConexion();
            }
        }
    }
}
