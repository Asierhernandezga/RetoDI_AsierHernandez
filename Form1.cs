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

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxPais.SelectedIndex = 0;
        }

        private void buttonContarSinParametros_Click(object sender, EventArgs e)
        {
            //METADATOS
            sql = "Select * from Peliculas";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();

            string acum = null;
            SqlDataReader dr;
            cont = 0;
            try
            {
                Conexion.AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    acum += dr.GetString(1) + Environment.NewLine;
                    cont += 1;
                }
                //acum += new string('-', 30);  // en c# no existe strdup
                //MessageBox.Show("" + cont);
                textBoxResultadoContar.Text = ""+cont;

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

        private void buttonContarConParametros_Click(object sender, EventArgs e)
        {
            //METADATOS


            string ComboText = comboBoxPais.Text;   //Para coger el texto del ComboBox

            sql = "Select * from Peliculas where Pais ='" + ComboText+ "'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            Conexion.AbrirConexion();

            string acum = null;
            SqlDataReader dr;
            cont = 0;
            try
            {
                Conexion.AbrirConexion();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    acum += dr.GetString(1) + Environment.NewLine;
                    cont += 1;
                }
                //acum += new string('-', 30);  // en c# no existe strdup
                //MessageBox.Show("" + cont);
                textBoxResultadoContar.Text = "" + cont;

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
