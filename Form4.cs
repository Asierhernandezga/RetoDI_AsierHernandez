using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DI_RetoCS
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private MiConexion Conexion = new MiConexion();
        private string sql;

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.Peliculas' Puede moverla o quitarla según sea necesario.
            this.PeliculasTableAdapter.Fill(this.DataSet1.Peliculas);

            this.reportViewer1.RefreshReport();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string pais = textBox1.Text.ToUpper();

            Conexion.AbrirConexion();
            sql = "Select * from peliculas where pais ='" + pais + "'";
            SqlCommand cmd = new SqlCommand(sql, Conexion.pConexion);
            SqlDataAdapter adap1 = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap1.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            Conexion.CerrarConexion();

        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            Conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaccion;

            //Inicia la transaccion
            transaccion = Conexion.pConexion.BeginTransaction();
            cmd.Connection = Conexion.pConexion;
            cmd.Transaction = transaccion;

            try
            {
                cmd.CommandText = "SELECT Precio FROM Peliculas WHERE CodPelicula = 113";
                resultado = Convert.ToDouble(cmd.ExecuteScalar());
                MessageBox.Show(resultado.ToString(), "inicial");

                cmd.CommandText = "UPDATE Peliculas SET Precio = Precio + 5  WHERE CodPelicula = 113";
                cmd.ExecuteNonQuery();


                cmd.CommandText = "UPDATE Productos SET UnitPrice = UnitPrice + 7.99  WHERE ProductID = 4"; //Va a fallar
                cmd.ExecuteNonQuery();

                transaccion.Commit();

            }
            catch (Exception)
            {
                transaccion.Rollback(); //Con esto vuelve hacia atras 

                MessageBox.Show("Se ha producido un error");    //Si ocurre un error

                cmd.CommandText = "SELECT Precio FROM Peliculas WHERE CodPelicula = 113";
                resultado = Convert.ToDouble(cmd.ExecuteScalar());

                MessageBox.Show(resultado.ToString(), "Es igual?");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Padre.f1.Activate();
        }
    }
}
