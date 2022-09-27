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
    public partial class CentroEducativo : Form
    {
        string alm = "maestros";
        controlador cn = new controlador();

        public CentroEducativo()
        {
            InitializeComponent();
        }


        //Mostrar los datos CAPA VISTA


        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(alm);
            //dgv_entradas.DataSource = dt;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void btn_docentes_Click(object sender, EventArgs e)
        {
            Form formDocentes = new Docentes();
            formDocentes.ShowDialog();
        }

        private void btn_Alumnos_Click(object sender, EventArgs e)
        {
            Form formAlumnos = new Alumnos();
            formAlumnos.ShowDialog();
        }
    }
}
