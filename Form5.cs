using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace DI_RetoCS
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string archivoJson = File.ReadAllText(@"JSON/stocks.json");

            //Lee todo

            DataTable dt = (DataTable)JsonConvert.DeserializeObject(archivoJson, typeof(DataTable));

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Padre.f1.Activate();
        }
    }
}
