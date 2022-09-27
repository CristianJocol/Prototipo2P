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
    public partial class Alumnos : Form
    {

        string alu = "alumnos";
        controlador cn = new controlador();

        public Alumnos()
        {
            InitializeComponent();
        }

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(alu);
            dgv_alumnos.DataSource = dt;

        }

        private void btn_alumnosDatos_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }
    }
}
