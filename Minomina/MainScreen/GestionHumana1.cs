using System;
using System.Windows.Forms;

namespace Minomina.View
{
    public partial class GestionHumana1 : Form
    {
        public GestionHumana1()
        {
            InitializeComponent();
        }

        private void btColaborador_MouseEnter(object sender, EventArgs e)
        {
            btColaborador.BackgroundImage = Properties.Resources.MenuColaboradorDobleAfuera;
        }
        private void btColaborador_MouseLeave(object sender, EventArgs e)
        {
            btColaborador.BackgroundImage = Properties.Resources.MenuColaboradorNormal;
        }

        private void btColaborador_Click(object sender, EventArgs e)
        {

            /*Colaboradores col = new Colaboradores();
            if (HelperForms.FormularioOpen(col.Name))
                return;
            else
                col.Show();

            */
        }

        private void btColaborador_MouseDown(object sender, MouseEventArgs e)
        {
            btColaborador.BackgroundImage = Properties.Resources.MenuColaboradorDobleDentro;
        }

        private void btColaborador_MouseUp(object sender, MouseEventArgs e)
        {
            btColaborador.BackgroundImage = Properties.Resources.MenuColaboradorDobleAfuera;
        }

        private void btPuesto_MouseEnter(object sender, EventArgs e)
        {
            btPuesto.BackgroundImage = Properties.Resources.MenuPuestoDobleAfuera;
        }
        private void btPuesto_MouseLeave(object sender, EventArgs e)
        {
            btPuesto.BackgroundImage = Properties.Resources.MenuPuestoNormal;
        }

        private void btPuesto_MouseDown(object sender, MouseEventArgs e)
        {
            btPuesto.BackgroundImage = Properties.Resources.MenuPuestoDobleDentro;
        }

        private void btPuesto_MouseUp(object sender, MouseEventArgs e)
        {
            btPuesto.BackgroundImage = Properties.Resources.MenuPuestoDobleAfuera;
        }

        private void btPuesto_Click(object sender, EventArgs e)
        {
            /*PuestoTrabajo pt = new PuestoTrabajo();

            if (HelperForms.FormularioOpen(pt.Name))
                return;
            else
                pt.Show();

            */
        }

        private void GestionHumana1_Load(object sender, EventArgs e)
        {

        }

        private void btDesvinculacion_MouseDown(object sender, MouseEventArgs e)
        {
            btDesvinculacion.BackgroundImage = Properties.Resources.DesvinculacionDentro;
        }

        private void btDesvinculacion_MouseUp(object sender, MouseEventArgs e)
        {
            btDesvinculacion.BackgroundImage = Properties.Resources.DesvinculacionAfuera1;
        }

        private void btDesvinculacion_MouseEnter(object sender, EventArgs e)
        {
            btDesvinculacion.BackgroundImage = Properties.Resources.DesvinculacionAfuera1;
        }

        private void btDesvinculacion_MouseLeave(object sender, EventArgs e)
        {
            btDesvinculacion.BackgroundImage = Properties.Resources.MenuDesvinculacionNormal;
        }
    }
}
