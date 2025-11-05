using SistemaNotas.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaNotas.Vista
{
    public partial class FrmCarrerasDocentes : Form
    {
        CarreraController carreras = new CarreraController();
        public FrmCarrerasDocentes()
        {
            InitializeComponent();
        }

        private void FrmCarrerasDocentes_Load(object sender, EventArgs e)
        {
            MostrarCarrrera();
        }

        private void MostrarCarrrera()
        {

            for (int i = 0; i < carreras.CargarJson("C:\\backup\\carreras.json").Count; i++)
            {
                string carrera = carreras.CargarJson("C:\\backup\\carreras.json")[i].Nombre;
                tvCarreras.Nodes.Add(carrera);
                tvCarreras.ExpandAll();
            }
        }
    }
}
