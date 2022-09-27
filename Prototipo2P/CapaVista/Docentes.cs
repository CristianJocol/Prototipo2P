using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Docentes : Form
    {

        string maes = "maestros";
        controlador cn = new controlador();

        public Docentes()
        {
            InitializeComponent();
        }

        private void Docentes_Load(object sender, EventArgs e)
        {

        }


        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(maes);
            dgv_maestros.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void dgv_maestros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
